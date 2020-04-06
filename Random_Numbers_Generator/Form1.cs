using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Numbers_Generator
{
    public partial class Home : Form
    {
        Random random = new Random();



        #region Initialization of the form
        public Home()
        {
            InitializeComponent();

            btnGenerate.Enabled = false;            

            btnReGenerate.Hide();

            txtFrom.MaxLength = 9;
            txtTo.MaxLength = 9;
            txtAmount.MaxLength = 9;

        }
        #endregion

        #region FUNCTIONS

        #region FUNCTION: Shows the "Re-Generate" button
        void AllowRegenerate()
        {
            btnReGenerate.Show();
            btnGenerate.Text = "Generate more";
        }
        #endregion

        #region FUNCTION: Re-generates the numbers to the main text box
        void RandomNumsToMainTxtBox()
        {
            int valueFrom = int.Parse(txtFrom.Text);
            int valueTo = int.Parse(txtTo.Text);
            int valueAmount = int.Parse(txtAmount.Text);

            try
            {
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
        #endregion

        #region FUNCTION: Generates more random numbers
        void GenerateMoreToMainTxtBox()
        {
            int valueFrom = int.Parse(txtFrom.Text);
            int valueTo = int.Parse(txtTo.Text);
            int valueAmount = int.Parse(txtAmount.Text);

            try
            {
                int nums = random.Next(valueFrom, valueTo);           // First random number

                txtRandomNumbers.Text += nums.ToString() + "\n";

                string newTxt = "";

                for (int i = 0; i < valueAmount - 1; i++)             // First random number was already printed out
                {
                    nums = random.Next(valueFrom, valueTo);

                    txtRandomNumbers.Text += nums.ToString() + "\n";  // txtRandomNumbers.Text = txtRandomNumbers.Text + ...
                    newTxt = txtRandomNumbers.Text;

                }
                txtRandomNumbers.Text = newTxt + "\n";
            }
            catch { }


        }
        #endregion

        #endregion

        #region EVENTS: TextChanged

        #region EVENT: TxtFrom_TextChanged
        private void TxtFrom_TextChanged(object sender, EventArgs e)
        {
            int numFrom;
            int numTo;

            int.TryParse(txtFrom.Text, out numFrom);
            int.TryParse(txtTo.Text, out numTo);

            if (numFrom < numTo)
            {
                    btnGenerate.Enabled = true;
            }
            else
            {
                btnGenerate.Enabled = false;
            }
        }
        #endregion

        #region EVENT: TxtAmount_TextChanged
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            int numAmount;
            if (int.TryParse(txtAmount.Text, out numAmount))
            {
                if (numAmount > 1)
                {
                    btnGenerate.Enabled = true;
                }
            }
            else
            {
                btnGenerate.Enabled = false;
            }
        }
        #endregion

        #region TxtRandomNumbers_TextChanged
        private void TxtRandomNumbers_TextChanged(object sender, EventArgs e)
        {
            txtRandomNumbers.SelectionStart = txtRandomNumbers.Text.Length;
            txtRandomNumbers.ScrollToCaret();
        }
        #endregion

        #endregion

        #region EVENTS: KeyPress

        #region EVENT: TxtFrom_KeyPress
        private void TxtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
            //{
            //    e.Handled = true;
            //}

            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region EVENT: TxtTo_KeyPress
        private void TxtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region EVENT: TxtAmount_KeyPress
        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion

        #endregion

        #region BUTTONS: Generate and Re-Generate numbers

        #region BUTTON: Generate 
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateMoreToMainTxtBox();
            AllowRegenerate();
        }
        #endregion

        #region BUTTON: Re-Generate
        private void BtnReGenerate_Click(object sender, EventArgs e)
        {
            RandomNumsToMainTxtBox();
        }



        #endregion

        #endregion








    }
}
