using System;
using System.Windows.Forms;

namespace Random_Numbers_Generator
{
    public partial class Home : Form
    {
        int valueFrom, valueTo, valueAmount;
        Random random;

        public Home()
        {
            InitializeComponent();
            Config();
        }

        void Config()
        {
            random = new Random();
        
            btnGenerate.Enabled = false;

            btnReGenerate.Hide();

            txtFrom.MaxLength = 9;
            txtTo.MaxLength = 9;
            txtAmount.MaxLength = 9;
        }

        void ParseValues()
        {
            valueFrom = int.Parse(txtFrom.Text);
            valueTo = int.Parse(txtTo.Text) + 1;
            valueAmount = int.Parse(txtAmount.Text);
        }

        // FUNCTION: Shows the "Re-Generate" button
        void AllowRegenerate()
        {
            btnReGenerate.Show();
            btnGenerate.Text = "Generate more";
        }

        // FUNCTION: Re-generates the numbers to the main text box
        void RandomNumsToMainTxtBox()
        {
            try
            {
                ParseValues();

                int nums = random.Next(valueFrom, valueTo);           // First random number
                txtRandomNumbers.Text = nums.ToString();

                for (int i = 0; i < valueAmount - 1; i++)             // First random number was already printed out
                {
                    nums = random.Next(valueFrom, valueTo);
                    txtRandomNumbers.Text += "\n" + nums.ToString();  

                }
                txtRandomNumbers.Text += "\n" + "\n";
            }
            catch { }
        }

        // FUNCTION: Generates more random numbers
        void GenerateMoreToMainTxtBox()
        {
            if (txtFrom.Text != string.Empty && txtTo.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                ParseValues();

                int nums;
                string newTxt = "";

                if (valueAmount == 1)
                {
                    nums = random.Next(valueFrom, valueTo);
                    txtRandomNumbers.Text += nums.ToString() + "\n" + "\n";
                }
                else
                {
                    for (int i = 0; i < valueAmount; i++)             // First random number was already printed out
                    {
                        nums = random.Next(valueFrom, valueTo);

                        txtRandomNumbers.Text += nums.ToString() + "\n";
                        newTxt = txtRandomNumbers.Text;
                    }
                    txtRandomNumbers.Text += "\n";
                }
            }
        }

        // EVENT: TextChanged
        private void TxtChanged(object sender, EventArgs e)
        {
            if (txtFrom.Text != string.Empty && txtTo.Text != string.Empty && txtAmount.Text != string.Empty)
            {
                ParseValues();

                if (valueFrom < valueTo && valueAmount > 0)
                {
                    btnGenerate.Enabled = true;
                    btnReGenerate.Enabled = true;
                }
                else
                {
                    btnGenerate.Enabled = false;
                    btnReGenerate.Enabled = false;
                }
            }
        }

        // EVENT: TxtRandomNumbers_TextChanged
        private void TxtRandomNumbers_TextChanged(object sender, EventArgs e)
        {
            txtRandomNumbers.SelectionStart = txtRandomNumbers.Text.Length;
            txtRandomNumbers.ScrollToCaret();
        }

        // EVENT: TxtFrom_KeyPress
        private void TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        // BUTTON: Generate 
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateMoreToMainTxtBox();
            AllowRegenerate();
        }

        // BUTTON: Re-Generate
        private void BtnReGenerate_Click(object sender, EventArgs e)
        {
            RandomNumsToMainTxtBox();
        }
    }
}
