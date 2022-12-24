using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _3280_Assignment1_Program1
{
    /// <summary>
    /// Form class
    /// </summary>
        public partial class Form1 : Form
        {
        /// <summary>
        /// Form main method
        /// </summary>
            public Form1()
            {
                InitializeComponent();
            //All of the starting text
            title.Text = "Are you allowed to have a computer?";
            phone_number_q.Text = "What is your phone number?";
            phone_number_prompt.Text = "Submitting enters you into a raffle!";

            credit_card_q.Text = "What is your credit card number?";
            credit_card_prompt.Text = "Work from home for $10,000 a month!";

            bank_info_q.Text = "What is your bank information?";
            bank_info_prompt.Text = "Wire money to a Nigerian prince to help him access his bank account!";
        }


        /// <summary>
        /// Clicking no on phone number question 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phone_number_no_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            string message = "You chose no. Congratulations, you won't get spam! You can use a computer without doing anything else."; 

            MyResult = MessageBox.Show(message);

            phone_number_prompt.Text = "You chose no."; 
        }

        /// <summary>
        /// Clicking submit on phone number question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phone_number_submit_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            string message = "You chose to submit. You entered: " + phone_number_text.Text + ". You will now receive a ton of spam. Please set up call blocking before continuing to use a computer."; 

            MyResult = MessageBox.Show(message); 

            phone_number_prompt.Text = "You submitted: " + phone_number_text.Text;
        }


        /// <summary>
        /// Clicking no on credit card info question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void credit_card_no_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            string message = "You chose no. Congratulations, you won't lose all of your money! You can use a computer without doing anything else."; 

            MyResult = MessageBox.Show(message);

            phone_number_prompt.Text = "You chose no.";

        }

        /// <summary>
        /// Clicking submit on credit card question 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void credit_card_submit_Click(object sender, EventArgs e)
        {
                DialogResult MyResult;

            string message = "You chose to submit. You entered: " + credit_card_text.Text + ". You will now be vulnerable to losing your money. Please contact your bank to cancel your card before continuing to use a computer."; 

            MyResult = MessageBox.Show(message);

                credit_card_prompt.Text = "You submitted: " + credit_card_text.Text;
            }

        /// <summary>
        /// Clicking no on bank info question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bank_info_no_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            string message = "You chose no. Congratulations, you won't lose $30,000! You can use a computer without doing anything else."; 

            MyResult = MessageBox.Show(message);

            bank_info_prompt.Text = "You chose no.";
        }


        /// <summary>
        /// Clicking submit on bank info question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bank_info_submit_Click(object sender, EventArgs e)
        {
            DialogResult MyResult;

            string message = "You chose to submit. You entered: " + bank_info_text.Text + ". You will now be vulnerable to losing your money. Please contact your bank to dig you out of this hole before continuing to use a computer."; 

            MyResult = MessageBox.Show(message);

            bank_info_prompt.Text = "You chose no.";
        }
    }
}