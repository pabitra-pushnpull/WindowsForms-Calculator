namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtBox_Result.Text == "0")
            
            txtBox_Result.Clear();

            Button bt = (Button)sender;
            txtBox_Result.Text += bt.Text;



            txtBox_Result.SelectionStart = txtBox_Result.Text.Length;
            txtBox_Result.ScrollToCaret();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
        
            txtBox_Result.Clear();
            txtBox_Result.Text = "0";
        }

        private void btnFullStop_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string operation = txtBox_Result.Text;
            int len = operation.Length;

            if (len != 0)
            {
                char lastCharacter = operation[len - 1];

                if (lastCharacter == '-' || lastCharacter == '×' || lastCharacter == '/')
                {
                    txtBox_Result.Text = txtBox_Result.Text.Remove(len - 1);
                    txtBox_Result.Text += "+";
                }
                else
                {
                    txtBox_Result.Text += "+";
                }
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string operation = txtBox_Result.Text;
            int len = operation.Length;

            if (len != 0)
            {
                char lastCharacter = operation[len - 1];

                if (lastCharacter == '+' || lastCharacter == '×' || lastCharacter == '/')
                {
                    txtBox_Result.Text = txtBox_Result.Text.Remove(len - 1);
                    txtBox_Result.Text += "-";
                }
                else
                {
                    txtBox_Result.Text += "-";
                }
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string operation = txtBox_Result.Text;
            int len = operation.Length;

            if (len != 0)
            {
                char lastCharacter = operation[len - 1];

                if (lastCharacter == '+' || lastCharacter == '-' || lastCharacter == '/')
                {
                    txtBox_Result.Text = txtBox_Result.Text.Remove(len - 1);
                    txtBox_Result.Text += "×";
                }
                else
                {
                    txtBox_Result.Text += "×";
                }
            }

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            String operation = txtBox_Result.Text;
            int len = operation.Length;

            if (len != 0)
            {
                char last = operation[len - 1];

                if (last == '+' || last == '-' || last == '×')
                {
                    txtBox_Result.Text = txtBox_Result.Text.Remove(len - 1);
                    txtBox_Result.Text += "/";
                }
                else
                {
                    txtBox_Result.Text += "/";
                }

            }

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            String display = txtBox_Result.Text;
            int len = display.Length;

            if (len == 0 || txtBox_Result.Text == "0")
            {
                return;
            }
            else
            {
                txtBox_Result.Text = txtBox_Result.Text.Remove(len - 1);

                if (txtBox_Result.Text == "")
                {
                    txtBox_Result.Text = "0";
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            char lastCharacter = txtBox_Result.Text[txtBox_Result.Text.Length - 1];
            if (lastCharacter == '+' || lastCharacter == '-' || lastCharacter == '×' || lastCharacter == '/')
            {
                return;
            }

            string operation = txtBox_Result.Text;

            if (operation.Contains('+'))
            {
                String[] parts = operation.Split('+');
                double result = Convert.ToDouble(parts[0]) + Convert.ToDouble(parts[1]);
                txtBox_Result.Text = result.ToString();
            }
            else if (operation.Contains('-'))
            {
                String[] parts = operation.Split('-');
                double result = Convert.ToDouble(parts[0]) - Convert.ToDouble(parts[1]);
                txtBox_Result.Text = result.ToString();
            }
            else if (operation.Contains('×'))
            {
                String[] parts = operation.Split('×');
                double result = Convert.ToDouble(parts[0]) * Convert.ToDouble(parts[1]);
                txtBox_Result.Text = result.ToString();
            }
            else if (operation.Contains('/'))
            {
                String[] parts = operation.Split('/');
                double result = Convert.ToDouble(parts[0]) / Convert.ToDouble(parts[1]);
                txtBox_Result.Text = result.ToString();
            }
            //430 546
        }
    }
}
