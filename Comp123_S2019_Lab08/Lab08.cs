using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_S2019_Lab08
{
    public partial class Lab08 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the default Constructor
        /// </summary>
        public Lab08()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the Event handler for the Lab08Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
        }      

        

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the Event Handler for  the NameTextBox Textchanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }
        /// <summary>
        /// This is the Event handler for Clear form
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
           //option A
            //UserAge = Convert.ToSingle(AgeTextbox.Text);
            //option B
            UserAge = float.Parse(AgeTextBox.Text);
            //option C
            //float tempFloat;
            //bool result = float.TryParse(AgeTextbox.Text, out tempFloat);
            //UserAge = tempFloat;
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
        }
    }
}
