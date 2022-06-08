using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.Views.CommonForm;
using PBL3.DTO;
using PBL3.BLL;

namespace PBL3.Views.CustomerForm
{
    public partial class InformationUpdateForm : Form
    {
        public delegate void MyDel(Form form);
        public MyDel openInformationForm;
        public InformationUpdateForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UserBLL.UpdateUserInformation(LoginInfo.UserID, phoneTextbox.Texts, nameTextbox.Texts, addressTextbox.Texts);
            openInformationForm(new InformationForm());
        }

    }
}
