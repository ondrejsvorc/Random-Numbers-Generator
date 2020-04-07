using System;
using System.Windows.Forms;

namespace Random_Numbers_Generator
{
    public partial class Home : Form
    {
        Random random = new Random();


        // Initialization of the form
        public Home()
        {
            InitializeComponent();

            btnGenerate.Enabled = false;            

            btnReGenerate.Hide();

            txtFrom.MaxLength = 9;
            txtTo.MaxLength = 9;
            txtAmount.MaxLength = 9;
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
                int valueFrom = int.Parse(txtFrom.Text);
                int valueTo = int.Parse(txtTo.Text);
                int valueAmount = int.Parse(txtAmount.Text);

                int nums = random.Next(valueFrom, valueTo);           // First random number
                txtRandomNumbers.Text = nums.ToString();

                for (int i = 0; i < valueAmount - 1; i++)             // First random number was already printed out
                {
                    nums = random.Next(valueFrom, valueTo);
                    txtRandomNumbers.Text += "\n" + nums.ToString();  // txtRandomNumbers.Text = txtRandomNumbers.Text + ...

                }
                txtRandomNumbers.Text += "\n" + "\n";
            }
            catch { }
        }




        // FUNCTION: Generates more random numbers
        void GenerateMoreToMainTxtBox()
        {
            try
            {
                int valueFrom = int.Parse(txtFrom.Text);
                int valueTo = int.Parse(txtTo.Text);
                int valueAmount = int.Parse(txtAmount.Text);


                int nums = random.Next(valueFrom, valueTo);           // First random number

                txtRandomNumbers.Text += nums.ToString() + "\n";

                string newTxt = "";

                for (int i = 0; i < valueAmount - 1; i++)             // First random number was already printed out
                {
                    nums = random.Next(valueFrom, valueTo);

                    txtRandomNumbers.Text += nums.ToString() + "\n";  
                    newTxt = txtRandomNumbers.Text;

                }
                txtRandomNumbers.Text = newTxt + "\n";
            }
            catch { }


        }




        // EVENT: TxtFrom_TextChanged
        private void TxtFrom_TextChanged(object sender, EventArgs e)
        {
            int numFrom;
            int numTo;
            int numAmount;

            int.TryParse(txtFrom.Text, out numFrom);
            int.TryParse(txtTo.Text, out numTo);
            int.TryParse(txtAmount.Text, out numAmount);


            if (numFrom < numTo && numAmount > 1)
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


        // EVENT: TxtAmount_TextChanged
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            int numAmount;

            int numFrom;
            int numTo;
  

            int.TryParse(txtFrom.Text, out numFrom);
            int.TryParse(txtTo.Text, out numTo);

            if (int.TryParse(txtAmount.Text, out numAmount))
            {
                if (numAmount > 1 && numFrom < numTo)
                {
                    btnGenerate.Enabled = true;
                    btnReGenerate.Enabled = true;
                }
            }
            else
            {
                btnGenerate.Enabled = false;
                btnReGenerate.Enabled = false;
            }
        }


        // TxtRandomNumbers_TextChanged
        private void TxtRandomNumbers_TextChanged(object sender, EventArgs e)
        {
            txtRandomNumbers.SelectionStart = txtRandomNumbers.Text.Length;
            txtRandomNumbers.ScrollToCaret();
        }





        // EVENT: TxtFrom_KeyPress
        private void TxtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }



        // EVENT: TxtTo_KeyPress
        private void TxtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        
        
        

        // EVENT: TxtAmount_KeyPress
        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
