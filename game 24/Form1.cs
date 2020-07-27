using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            number5.Visible = false;
            number6.Visible = false;
            number7.Visible = false;
            answer_number.Visible = false;
        }

        bool game_clear = true;
        int count;
        private void random_number(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Random random = new Random();
            if (game_clear == true)
            {
                number1.Text = random.Next(1, 9).ToString();
                number2.Text = random.Next(1, 9).ToString();
                number3.Text = random.Next(1, 9).ToString();
                number4.Text = random.Next(1, 9).ToString();
                count = count + 1;
                random_num.Text = "random " + count + "/4";
                button_show(button, e);
                answer_number.Visible = false;
                game_clear = false;
            } else
            {
                MessageBox.Show("please clear this round");
            }
        }

        private void button_num(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (number1.Text == "number 1")
            {
                MessageBox.Show("please click random to start");
            } else
            {
                if (textBox1.Text != "")
                    textBox2.Text = button.Text;
                else
                    textBox1.Text = button.Text;
                button.Visible = false;
            }
        }

        private void button_clear(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (game_clear == true)
            {
                MessageBox.Show("please click random to start new round");
            } else
            {
                textBox1.Text = textBox2.Text = "";
                button_show(button, e);
            }
        }

        private void button_show(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (answer.Text != "answer")
            {
                answer.Text = "answer";
                answer.Visible = false;
            }
            number1.Visible = number2.Visible = number3.Visible = number4.Visible = true;
            number5.Visible = number6.Visible = number7.Visible = false;
            number5.Text = "number 5";
            number6.Text = "number 6";
            number7.Text = "number 7";
        }

        private void button_symbol(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            symbol.Text = button.Text;
        }

        double num1;
        double num2;
        string operate = " ";
        private void calculate(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operate = symbol.Text;

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please choose number");
            } else
            {
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);

                if (symbol.Text == "symbol")
                {
                    MessageBox.Show("please choose symbol");
                }
                else
                {
                    switch (operate)
                    {
                        case "+":
                            answer.Text = (num1 + num2).ToString();
                            break;
                        case "-":
                            answer.Text = (num1 - num2).ToString();
                            break;
                        case "*":
                            answer.Text = (num1 * num2).ToString();
                            break;
                        case "/":
                            answer.Text = (num1 / num2).ToString();
                            break;
                        default:
                            break;
                    }

                    textBox1.Clear();
                    textBox2.Clear();
                }

                if (answer.Text != "answer")
                {
                    if (number5.Text == "number 5")
                    {
                        number5.Visible = true;
                        number5.Text = answer.Text;
                    }
                    else if (number5.Text != "number 5" && number6.Text == "number 6")
                    {
                        number6.Visible = true;
                        number6.Text = answer.Text;
                    }
                    else if (number5.Text != "number 5" && number6.Text != "number 6" && number7.Text == "number 7")
                    {
                        number7.Visible = true;
                        number7.Text = answer.Text;
                    }

                    checkpoint(button, e);
                }
            }
        }

        int check;
        int point;
        int myscore;
        private void checkpoint(object sender, EventArgs e)
        {
            if (number7.Text != "number 7")
            {
                check = int.Parse(number7.Text);
                answer_number.Visible = true;
                if (check == 24)
                {
                    point = 25;
                }
                else if (check > 24)
                {
                    point = 24 - (check - 24);
                }
                else if (check < 24)
                {
                    point = 24 - (24 - check);
                }
                answer_number.Text = "your point is " + point.ToString();
                myscore = myscore + point;
                score.Text = "your score is " + myscore.ToString();
                game_clear = true;

                if (count == 4)
                {
                    Button button = (Button)sender;
                    MessageBox.Show("your score is " + myscore + " please click ok to play new game");
                    count = 0;
                    random_number(button, e);
                }
            }
        }
    }
}
