using System.Collections.Specialized;

namespace calculator
{
    public partial class MyCalculator : Form
    {
        bool isfirst = true;
        int op1, op2;
        double op3;

        char opr;
        string op;
        public MyCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "2";
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {
            op2 = int.Parse(screen.Text);
            op3 = double.Parse(screen.Text);

            switch (opr)
            {
                case '+':
                    screen.Text = (op1 + op2).ToString();
                    break;
                case '-':
                    screen.Text = (op1 - op2).ToString();
                    break;
                case 'x':
                    screen.Text = (op1 * op2).ToString();
                    break;
                case '/':
                    screen.Text = (op1 / op3).ToString();
                    break;
                case '%':
                    screen.Text = (op1 % op2).ToString();
                    break;
            }
            switch (op)
            {
                case "x^2":
                    screen.Text = (op1 * op1).ToString();
                    break;
                case "clr":
                   // screen.Text = "";
                    break;
                case "x^1/2":
                    screen.Text = (Math.Sqrt(op1)).ToString();
                    break;
                case "^":
                    screen.Text = (Math.Pow(op1,op2)).ToString();
                    break;
                case "ln":
                    screen.Text = (Math.Log(op3)).ToString();
                    break;
                case "sin":
                    screen.Text = (Math.Sin(op3)).ToString();
                    break;
                case "cos":
                    screen.Text = (Math.Cos(op3)).ToString();
                    break;
                case "log":
                    screen.Text = (Math.Log10(op3)).ToString();
                    break;
                case "tan":
                    screen.Text = (Math.Tan(op3)).ToString();
                    break;
                case "cot":
                    screen.Text = (Math.Tanh(op3)).ToString();
                    break;
                case "sec":
                    screen.Text = (Math.Cosh(op3)).ToString();
                    break;
                case "cosine":
                    screen.Text = (Math.Sinh(op3)).ToString();
                    break;
                case "fact":
                    int ans = 1;
                    for(int i = 2; i <= op1; i++)
                    {
                        ans *= i;
                    }
                    screen.Text = ans.ToString();
                    break;
            }

        }

        private void three_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (isfirst)
            {
                screen.Text = "";
                isfirst = false;
            }
            screen.Text += "9";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            opr = '-';
            isfirst = true;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            opr = 'x';
            isfirst = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            opr = '/';
            isfirst = true;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            opr = '%';
            isfirst = true;
        }

        private void square_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "x^2";
            isfirst = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //op1 = int.Parse(screen.Text);
            //op = "clr";
            isfirst = true;
            screen.Text = "0";

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "x^1/2";
            isfirst = true;
        }

        private void power_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "^";
            isfirst = true;

        }

        private void log_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "ln";
            isfirst = true;
        }

        private void sine_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "sin";
            isfirst = true;
        }

        private void cosine_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "cos";
            isfirst = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (screen.Text=="0")
            {
                return;
            }
            else
            {
                screen.Text += "0";
            }
        }

        private void logof_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "log";
            isfirst = true;
        }

        private void tangent_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "tan";
            isfirst = true;
        }

        private void secant_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "sec";
            isfirst = true;
        }

        private void cosin_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "cosine";
            isfirst = true;
        }

        private void cotang_Click(object sender, EventArgs e)
        {
            op3 = double.Parse(screen.Text);
            op = "cot";
            isfirst = true;
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            op = "fact";
            isfirst = true;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0)
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
            }

        }

        private void plus_Click(object sender, EventArgs e)
        {
            op1 = int.Parse(screen.Text);
            opr = '+';
            isfirst = true;
        }
    }
}