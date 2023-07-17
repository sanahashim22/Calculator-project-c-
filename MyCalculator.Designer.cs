namespace calculator
{
    partial class MyCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.screen = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.cosine = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.logof = new System.Windows.Forms.Button();
            this.secant = new System.Windows.Forms.Button();
            this.cosin = new System.Windows.Forms.Button();
            this.tangent = new System.Windows.Forms.Button();
            this.cotang = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.screen.Location = new System.Drawing.Point(21, 22);
            this.screen.Name = "screen";
            this.screen.ReadOnly = true;
            this.screen.Size = new System.Drawing.Size(616, 50);
            this.screen.TabIndex = 0;
            this.screen.Text = "0";
            this.screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(21, 300);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(83, 52);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(127, 300);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(83, 52);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(127, 89);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(83, 52);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(568, 374);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(69, 50);
            this.equal.TabIndex = 4;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(21, 89);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(83, 52);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(127, 161);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(83, 52);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(235, 161);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(87, 52);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(21, 161);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(83, 52);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(21, 231);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(83, 52);
            this.four.TabIndex = 6;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(127, 231);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(83, 52);
            this.five.TabIndex = 7;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(235, 231);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(87, 52);
            this.six.TabIndex = 8;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(235, 300);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(87, 52);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(235, 89);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(87, 52);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(568, 231);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(69, 52);
            this.square.TabIndex = 14;
            this.square.Text = "x^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(21, 374);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(83, 52);
            this.mod.TabIndex = 15;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(235, 374);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(87, 52);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(568, 303);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(69, 49);
            this.power.TabIndex = 17;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(348, 161);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(88, 52);
            this.log.TabIndex = 18;
            this.log.Text = "ln";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(568, 89);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(69, 52);
            this.clear.TabIndex = 20;
            this.clear.Text = "clr";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(348, 89);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(88, 52);
            this.sqrt.TabIndex = 21;
            this.sqrt.Text = "x^1/2";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // cosine
            // 
            this.cosine.Location = new System.Drawing.Point(348, 374);
            this.cosine.Name = "cosine";
            this.cosine.Size = new System.Drawing.Size(88, 52);
            this.cosine.TabIndex = 22;
            this.cosine.Text = "cos";
            this.cosine.UseVisualStyleBackColor = true;
            this.cosine.Click += new System.EventHandler(this.cosine_Click);
            // 
            // sine
            // 
            this.sine.Location = new System.Drawing.Point(348, 300);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(88, 52);
            this.sine.TabIndex = 23;
            this.sine.Text = "sin";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.Click += new System.EventHandler(this.sine_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(127, 374);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(83, 52);
            this.zero.TabIndex = 24;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // logof
            // 
            this.logof.Location = new System.Drawing.Point(348, 231);
            this.logof.Name = "logof";
            this.logof.Size = new System.Drawing.Size(88, 52);
            this.logof.TabIndex = 25;
            this.logof.Text = "log";
            this.logof.UseVisualStyleBackColor = true;
            this.logof.Click += new System.EventHandler(this.logof_Click);
            // 
            // secant
            // 
            this.secant.Location = new System.Drawing.Point(464, 89);
            this.secant.Name = "secant";
            this.secant.Size = new System.Drawing.Size(82, 50);
            this.secant.TabIndex = 26;
            this.secant.Text = "sec";
            this.secant.UseVisualStyleBackColor = true;
            this.secant.Click += new System.EventHandler(this.secant_Click);
            // 
            // cosin
            // 
            this.cosin.Location = new System.Drawing.Point(464, 231);
            this.cosin.Name = "cosin";
            this.cosin.Size = new System.Drawing.Size(82, 52);
            this.cosin.TabIndex = 27;
            this.cosin.Text = "cosine";
            this.cosin.UseVisualStyleBackColor = true;
            this.cosin.Click += new System.EventHandler(this.cosin_Click);
            // 
            // tangent
            // 
            this.tangent.Location = new System.Drawing.Point(464, 161);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(82, 52);
            this.tangent.TabIndex = 28;
            this.tangent.Text = "tan";
            this.tangent.UseVisualStyleBackColor = true;
            this.tangent.Click += new System.EventHandler(this.tangent_Click);
            // 
            // cotang
            // 
            this.cotang.Location = new System.Drawing.Point(464, 374);
            this.cotang.Name = "cotang";
            this.cotang.Size = new System.Drawing.Size(82, 52);
            this.cotang.TabIndex = 29;
            this.cotang.Text = "cot";
            this.cotang.UseVisualStyleBackColor = true;
            this.cotang.Click += new System.EventHandler(this.cotang_Click);
            // 
            // factorial
            // 
            this.factorial.Location = new System.Drawing.Point(464, 300);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(82, 52);
            this.factorial.TabIndex = 30;
            this.factorial.Text = "fact";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(568, 161);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(69, 52);
            this.delete.TabIndex = 31;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(654, 438);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.cotang);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.cosin);
            this.Controls.Add(this.secant);
            this.Controls.Add(this.logof);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.cosine);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.log);
            this.Controls.Add(this.power);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.square);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.screen);
            this.Name = "MyCalculator";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.MyCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox screen;
        private Button one;
        private Button two;
        private Button plus;
        private Button equal;
        private Button minus;
        private Button eight;
        private Button nine;
        private Button seven;
        private Button four;
        private Button five;
        private Button six;
        private Button three;
        private Button multiply;
        private Button square;
        private Button mod;
        private Button divide;
        private Button power;
        private Button log;
        private Button clear;
        private Button sqrt;
        private Button cosine;
        private Button sine;
        private Button zero;
        private Button logof;
        private Button secant;
        private Button cosin;
        private Button tangent;
        private Button cotang;
        private Button factorial;
        private Button delete;
        private ColorDialog colorDialog1;
    }
}