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

namespace PBL3.Views.AdminForms
{
    public partial class AdminMainPage : Form
    {
        private Form activeForm = null;
        public AdminMainPage()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard());
        }

        private void articleManagementBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticleManagementForm());
        }

        private void informationManagementBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserManagementForm());
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chatbox());
        }
    }
}
