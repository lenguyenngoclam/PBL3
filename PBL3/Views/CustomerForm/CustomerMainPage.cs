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
    public partial class CustomerMainPage : Form
    {
        private Form activeForm = null;
        public CustomerMainPage()
        {
            InitializeComponent();
            panelInfomationSubmenu.Visible = false;
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

        private void hideSubmenu()
        {
            if(panelInfomationSubmenu.Visible)
                panelInfomationSubmenu.Visible = false;
        }

        private void toggleSubmenu(Panel panel){
            if (panel.Visible == false)
            {
                hideSubmenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            OpenChildForm(new Dashboard());
        }

        private void informationBtn_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelInfomationSubmenu);
        }

        private void articleManagementBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            OpenChildForm(new ArticleManagementForm());
        }

        private void MessageBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            OpenChildForm(new Chatbox());
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void idBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InformationForm());
        }

        private void infomationChangeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InformationUpdateForm());
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePasswordForm());
        }

        private void changePhoneBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePhoneNumberForm());
        }
    }
}
