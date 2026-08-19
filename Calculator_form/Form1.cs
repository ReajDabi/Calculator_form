
namespace Calculator_form
{
    public partial class winCalculator : Form
    {
        public winCalculator()
        {
            InitializeComponent();
        }
        double FirstNumber;
        string Operation;
        private void lblResult_Click(object sender, EventArgs e)
        {

        }



        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "1";
            }
            else
            {
                lblResult.Text = lblResult.Text + "1";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.Text = "0";
            FirstNumber = 0;
            Operation = "";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "7";
            }
            else
            {
                lblResult.Text = lblResult.Text + "7";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "2";
            }
            else
            {
                lblResult.Text = lblResult.Text + "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "3";
            }
            else
            {
                lblResult.Text = lblResult.Text + "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "4";
            }
            else
            {
                lblResult.Text = lblResult.Text + "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "5";
            }
            else
            {
                lblResult.Text = lblResult.Text + "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "6";
            }
            else
            {
                lblResult.Text = lblResult.Text + "6";
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "8";
            }
            else
            {
                lblResult.Text = lblResult.Text + "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (lblResult.Text == "0" && lblResult.Text != null)
            {
                lblResult.Text = "9";
            }
            else
            {
                lblResult.Text = lblResult.Text + "9";
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblResult.Text);
            lblResult.Text = "0";
            Operation = "/";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text + ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblResult.Text);
            lblResult.Text = "0";
            Operation = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblResult.Text);
            lblResult.Text = "0";
            Operation = "-";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 1)
            {
                lblResult.Text = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
            }
            else
            {
                lblResult.Text = "0";
            }
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(lblResult.Text);
            lblResult.Text = "0";
            Operation = "x";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(lblResult.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                lblResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                lblResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                lblResult.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    lblResult.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    lblResult.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text+ "0";
        }
    }
}
