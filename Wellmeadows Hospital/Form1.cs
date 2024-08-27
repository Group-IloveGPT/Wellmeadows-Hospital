using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wellmeadows_Hospital.View;


namespace Wellmeadows_Hospital
{
    public partial class Form1 : Form
    { 
        private string correctUsername = "admin";
        private string correctPassword = "123";
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_SignIn_Click(object sender, EventArgs e)
        {
            string username = Txt_User.Text;
            string password = Txt_Password.Text;

            if (username == correctUsername && password == correctPassword)
            {
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide(); 
            }
            else
            {
                Lbl_Error.Text = "Incorrect username or password. Please try again.";
                Lbl_Error.ForeColor = Color.Red;
                Lbl_Error.Visible = true;
            }
        }
    }
}
