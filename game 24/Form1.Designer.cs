namespace game_24
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.random_num = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.symbol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.answer_number = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.by = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number1.Location = new System.Drawing.Point(80, 194);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(108, 138);
            this.number1.TabIndex = 0;
            this.number1.Text = "number 1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.button_num);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number2.Location = new System.Drawing.Point(194, 194);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(108, 138);
            this.number2.TabIndex = 1;
            this.number2.Text = "number 2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.button_num);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number3.Location = new System.Drawing.Point(308, 194);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(108, 138);
            this.number3.TabIndex = 2;
            this.number3.Text = "number 3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.button_num);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number4.Location = new System.Drawing.Point(422, 194);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(108, 138);
            this.number4.TabIndex = 3;
            this.number4.Text = "number 4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.button_num);
            // 
            // random_num
            // 
            this.random_num.Location = new System.Drawing.Point(251, 361);
            this.random_num.Name = "random_num";
            this.random_num.Size = new System.Drawing.Size(108, 49);
            this.random_num.TabIndex = 4;
            this.random_num.Text = "random 0/4";
            this.random_num.UseVisualStyleBackColor = true;
            this.random_num.Click += new System.EventHandler(this.random_number);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(308, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 22);
            this.textBox2.TabIndex = 6;
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Location = new System.Drawing.Point(224, 48);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(52, 17);
            this.symbol.TabIndex = 7;
            this.symbol.Text = "symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(477, 46);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(53, 17);
            this.answer.TabIndex = 9;
            this.answer.Text = "answer";
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number5.Location = new System.Drawing.Point(80, 71);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(108, 117);
            this.number5.TabIndex = 10;
            this.number5.Text = "number 5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.button_num);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number6.Location = new System.Drawing.Point(194, 71);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(108, 117);
            this.number6.TabIndex = 11;
            this.number6.Text = "number 6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.button_num);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.number7.Location = new System.Drawing.Point(308, 71);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(108, 117);
            this.number7.TabIndex = 12;
            this.number7.Text = "number 7";
            this.number7.UseVisualStyleBackColor = false;
            // 
            // answer_number
            // 
            this.answer_number.BackColor = System.Drawing.Color.Lime;
            this.answer_number.Location = new System.Drawing.Point(422, 71);
            this.answer_number.Name = "answer_number";
            this.answer_number.Size = new System.Drawing.Size(108, 117);
            this.answer_number.TabIndex = 13;
            this.answer_number.Text = "answer";
            this.answer_number.UseVisualStyleBackColor = false;
            this.answer_number.Click += new System.EventHandler(this.checkpoint);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(536, 194);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(56, 62);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button_symbol);
            // 
            // and
            // 
            this.and.Location = new System.Drawing.Point(536, 262);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(56, 70);
            this.and.TabIndex = 15;
            this.and.Text = "*";
            this.and.UseVisualStyleBackColor = true;
            this.and.Click += new System.EventHandler(this.button_symbol);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(598, 194);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(56, 62);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button_symbol);
            // 
            // by
            // 
            this.by.Location = new System.Drawing.Point(598, 262);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(56, 70);
            this.by.TabIndex = 17;
            this.by.Text = "/";
            this.by.UseVisualStyleBackColor = true;
            this.by.Click += new System.EventHandler(this.button_symbol);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(660, 194);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(56, 138);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.calculate);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(608, 361);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(108, 49);
            this.clear.TabIndex = 19;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button_clear);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.score.Location = new System.Drawing.Point(536, 71);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(180, 117);
            this.score.TabIndex = 20;
            this.score.Text = "your score is 0";
            this.score.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.by);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.and);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.answer_number);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.random_num);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button random_num;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button answer_number;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button by;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button score;
    }
}

