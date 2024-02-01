namespace Assign1Calc
{
    public partial class Form1 : Form
    {
        float num1, num2, result;
        string operators = "";
        bool done = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            bool containsDecimal = (txtDisplay.Text).Contains(".");


            if (txtDisplay.Text == "" || !containsDecimal)
            {
                txtDisplay.Text += ".";
            }

            else if (char.IsDigit(txtDisplay.Text.Last()))
            {
                txtDisplay.Text += ".";
            }


        }
  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!done)
            {
                num1 = float.Parse(txtDisplay.Text);
            }
            else
            {
                num1 = float.Parse(txtResult.Text);
                txtDisplay.Text = txtResult.Text;
            }
            txtDisplay.Text += " + ";
            operators = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                num1 = float.Parse(txtDisplay.Text);
            }
            else
            {
                num1 = float.Parse(txtResult.Text);
                txtDisplay.Text = txtResult.Text;
            }
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Text += " - ";
            operators = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                num1 = float.Parse(txtDisplay.Text);
            }
            else
            {
                num1 = float.Parse(txtResult.Text);
                txtDisplay.Text = txtResult.Text;
            }
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Text += " * ";
            operators = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                num1 = float.Parse(txtDisplay.Text);
            }
            else
            {
                num1 = float.Parse(txtResult.Text);
                txtDisplay.Text = txtResult.Text;
            }
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Text += " ÷ ";
            operators = "/";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (!done)
            {
                num1 = float.Parse(txtDisplay.Text);
            }
            else
            {
                num1 = float.Parse(txtResult.Text);
                txtDisplay.Text = txtResult.Text;
            }
            num1 = float.Parse(txtDisplay.Text);
            txtDisplay.Text += "%";
            operators = "%";
        }
        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    {
                        
                        int indexOfOperator = txtDisplay.Text.IndexOf("+");
                        if (indexOfOperator != -1)
                        {
                            string secondOperandString = txtDisplay.Text.Substring(indexOfOperator + 1).Trim();
                            if (float.TryParse(secondOperandString, out num2))
                            {
                                result = num1 + num2;
                                Console.WriteLine();
                                txtResult.Text = result.ToString();
                                done = true;
                            }
                            else
                            {
                            }
                        }
                        break;
                    }

                case "-":
                    {
                        int indexOfOperator = txtDisplay.Text.IndexOf("-");
                        if (indexOfOperator != -1)
                        {
                            string secondOperandString = txtDisplay.Text.Substring(indexOfOperator + 1).Trim();
                            if (float.TryParse(secondOperandString, out num2))
                            {
                                result = num1 - num2;
                                Console.WriteLine();
                                txtResult.Text = result.ToString();
                            }
                            else
                            {
                            }
                        }
                        break;
                    }

                case "*":
                    {
                        int indexOfOperator = txtDisplay.Text.IndexOf("*");
                        if (indexOfOperator != -1)
                        {
                            string secondOperandString = txtDisplay.Text.Substring(indexOfOperator + 1).Trim();
                            if (float.TryParse(secondOperandString, out num2))
                            {
                                result = num1 * num2;
                                Console.WriteLine();
                                txtResult.Text = result.ToString();
                            }
                            else
                            {
                            }
                        }
                        break;
                    }

                case "/":
                    {
                        int indexOfOperator = txtDisplay.Text.IndexOf("÷");
                        if (indexOfOperator != -1)
                        {
                            string secondOperandString = txtDisplay.Text.Substring(indexOfOperator + 1).Trim();
                            if (float.TryParse(secondOperandString, out num2))
                            {
                                if (num2 == 0)
                                {
                                    txtResult.Text = "Error";
                                }
                                else
                                {
                                    result = num1 / num2;
                                    Console.WriteLine();
                                    txtResult.Text = result.ToString();
                                }
                            }
                            else
                            {
                            }
                        }
                        break;
                    }

                case "%":
                    {
                        result = num1 / 100;
                        txtResult.Text = result.ToString();
                        break;
                    }
                default:
                    {
                        txtResult.Text = txtDisplay.Text;
                        break;
                    }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = txtDisplay.Text;
            if (txt.Length > 0)
            {
                txt = txt.Remove(txt.Length - 1);
            }
            txtDisplay.Text = txt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            txtDisplay.Text = "0";
            txtResult.Text = "0";
            done = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
