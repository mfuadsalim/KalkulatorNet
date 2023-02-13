namespace Kalkulator
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        private object txtDisplay2;

        public Form1()
        {
            InitializeComponent();
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


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            switch (txtDisplay)
            {
                case "/":
                    txtDisplay2.Text = "-";
                    break;
                case "*":
                    txtDisplay2.Text = "*";
                    break;
                case "+":
                    txtDisplay2.Text = "+";
                    break;
                case "-":
                    txtDisplay2.Text = "-";
                    break;
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

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay.Text = " ";
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Text = "/";
            txtDisplay.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Text = "*";
            txtDisplay.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Text = "-";
            txtDisplay.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(txtDisplay.Text);
            txtDisplay.Text = "+";
            txtDisplay.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay.Text);
            {
                switch (opr)
                {
                    case 1:
                        txtDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 2:
                        txtDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 3:
                        txtDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        txtDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }
    }
}