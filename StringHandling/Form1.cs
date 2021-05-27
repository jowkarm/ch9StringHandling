// Mohammad Jokar-Konavi and Behrooz Kazemi
// 05/25/2021
// Extra exercise 9-2


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            //Trim and split the email address
            string email = txtEmail.Text;
            string[] emailList = email.Trim().Split('@');

           
            //Show error message box
            if (emailList.Length != 2)
            {
                MessageBox.Show("The standard email format must contain one '@' symbol."
                    , "Invalid Entry!");
            }

            //Display the user name and domain name
            else
            {
                string userName = emailList[0];
                string domain = emailList[1];

                string messageText = "User name: " + userName + "\n"
                    + "Domain name: " + domain;
                MessageBox.Show(messageText, "Parsed String");
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            //Create variables
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;

            //capitalize the first letter of city
            string initialCap = city.Substring(0, 1).ToUpper();
            string lowerCaseLetters = city.Substring(1).ToLower();
            city = initialCap + lowerCaseLetters;

            //capitalize both letters of state
            state = state.ToUpper();

            string full = city + state + zipCode;

            //Use the insert method
            full = full.Insert(city.Length, ", ");
            full = full.Insert(city.Length + 4, " ");

            //Display the result
            full = "City, State, Zip: " + full;
            MessageBox.Show(full, "Formatted String");
        }
    }
}
