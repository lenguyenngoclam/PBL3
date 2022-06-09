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
using PBL3.BLL;

namespace PBL3.Views.AdminForms
{
    public partial class ArticleManagementForm : Form
    {
        public ArticleManagementForm()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            HouseInformationForm form = new HouseInformationForm(2);
            form.ShowDialog();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (PostBLL.CheckPosted(2))
            {
                MessageBox.Show("Bài đăng này được được duyệt");
            } else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn duyệt bài đăng này không ?",
                "Xác nhận",
                MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    PostBLL.BrowsePost(2);
                    MessageBox.Show("Duyệt bài thành công");
                }
                else
                    return;
            }

        }
    }
}
