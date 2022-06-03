using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.Views.AdminForms;
using PBL3.Views.CustomerForm;
using PBL3.Views.RenterForm;

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
            string username = usernameTextbox.Texts;
            string password = passwordTextbox.Texts;
            string role = AccountBLL.CheckRole(username, password);
            //Thong tin nhap sai nên phải return để tránh việc tắt form login
            if (role == "")
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác");
                return;
            }

            //Gán thông tin người dùng cho LoginInfo để sử dụng cho các form
            LoginInfo.UserID = UserBLL.GetUserIDByAccountID(AccountBLL.GetAccountID(username, password));

            //Thông tin nhập đúng thì chọn form tương ứng và tắt form login đi
            hideParentForm();
            if (role == "Admin")
            {
                AdminMainPage form = new AdminMainPage();
                form.ShowDialog();
            } else if(role == "Host")
            {
                CustomerMainPage form = new CustomerMainPage();
                form.ShowDialog();
            } else if(role == "Renter")
            {
                RenterMainPage form = new RenterMainPage();
                form.ShowDialog();
            } 
            closeParentForm();
        }
    }
}
