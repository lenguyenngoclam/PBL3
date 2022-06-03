using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.Views.CommonForm
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!validatePassword())
                MessageBox.Show("Mật khẩu xác nhận không chính xác");
            else
            {
                int userID = LoginInfo.UserID;
                if(AccountBLL.CheckPassword(
                    UserBLL.GetAccountIDByUserID(
                        userID), oldPassTextbox.Texts))
                {
                    AccountBLL.ChangePassowrd(UserBLL.GetAccountIDByUserID(userID), 
                        newPassTextbox.Texts);
                    this.Close();
                } else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                }
            }
        }

        private bool validatePassword()
        {
            if (newPassTextbox.Texts != confirmNewPassField.Texts)
                return false;
            return true;
        }
    }
}
