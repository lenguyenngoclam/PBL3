using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Views.AdminForms;

namespace PBL3.Views.CommonForm
{
    public partial class LoginForm : Form
    {
        public delegate void MyDel ();
        public MyDel hideParentForm;
        public MyDel closeParentForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            hideParentForm();
            AdminMainPage form = new AdminMainPage();
            form.ShowDialog();
            closeParentForm();
        }
    }
}
