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

namespace PBL3.Views.CustomerForm
{
    public partial class ArticleManagementForm : Form
    {
        public ArticleManagementForm()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            HouseInformationForm form = new HouseInformationForm(3);
            form.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            ArticleUpdateForm form = new ArticleUpdateForm(2);
            form.ShowDialog();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ArticlePostingForm form = new ArticlePostingForm();
            form.ShowDialog();
        }

    }
}
