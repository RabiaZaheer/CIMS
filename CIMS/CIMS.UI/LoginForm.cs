using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CIMS.BO;
using CIMS.BL;

namespace CIMS.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
             if (textBoxUName.Text == "")
            {
                MessageBox.Show("Username can't be empty");
            }
            else if(textBoxPwd.Text =="")
            {
                MessageBox.Show("Password can't be empty");
            }
 
            else
            {
                UserBO objUserBO = new UserBO();
                objUserBO.Username = textBoxUName.Text;
                objUserBO.Password = textBoxPwd.Text;
 
                UserBL objUserBL = new UserBL();
 
               // Boolean status = UserBL.objUserBL.DoLoginValidation(objUserBO);

                Boolean status = UserBL.DoLoginValidation(objUserBO);

                if (status == true)
                {
                    MessageBox.Show("You have successfully logged in");
                    WelcomeForm frmWelcome = new WelcomeForm();
                    // hiding the first form.
                    this.Hide();
                    // displaying the second form
                    frmWelcome.ShowDialog();
                }
 
                else
                {
                    MessageBox.Show("Invalid Login Try Again");
                }
            }
 
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }//button_click event
   
    }
}
