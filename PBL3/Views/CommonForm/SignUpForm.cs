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
using PBL3.DTO;

namespace PBL3.Views.CommonForm
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            AddWardToCbb();
        }

        private void AddWardToCbb()
        {
            WardBLL.GetAllWards().ForEach(ward => wardCbb.Items.Add(ward.WardName));
        }

        //Lấy dữ liệu từ các trường textbox và bỏ vào tuples
        private (string name, string email, string phone, string username,
            string password, string wardName, string detailAddr, int role) GetFormInformation()
        {
            int roleNum = (hostBtn.Checked) ? 2 : 3;

            return (nameTextbox.Texts, emailTextbox.Texts, phoneNumberTextbox.Texts,
                usernameTextbox.Texts, passwordTextbox.Texts, wardCbb.SelectedItem.ToString(),
                detailAddressTextbox.Texts, roleNum);
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            //Phân tách tuples vào trong các biến tương ứng
            var (name, email, phone, username, password, wardName, detailAddress, role) = GetFormInformation();
            
            if(AccountBLL.CheckExistingAccount(username, password))
            {
                MessageBox.Show("Tài khoản đã có người đăng ký");
            } else
            {
                AccountBLL.AddAccount(username: username, password: password, roleID: role);
                int addressID = AddressBLL.AddAddress(detailAddr: detailAddress,
                    wardID: WardBLL.GetWardIDByName(wardName));
                UserBLL.AddUser(accountID: AccountBLL.GetAccountID(username, password), name: name,
                    phone: phone, email: email, addressID: addressID);
                MessageBox.Show("Đăng ký thành công");
            }
            this.Close();
        }
    }
}
