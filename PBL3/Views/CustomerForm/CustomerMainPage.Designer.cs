﻿
namespace PBL3.Views.CustomerForm
{
    partial class CustomerMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.signOutBtn = new FontAwesome.Sharp.IconButton();
            this.MessageBtn = new FontAwesome.Sharp.IconButton();
            this.articleManagementBtn = new FontAwesome.Sharp.IconButton();
            this.panelInfomationSubmenu = new System.Windows.Forms.Panel();
            this.infomationChangeBtn = new FontAwesome.Sharp.IconButton();
            this.changePhoneBtn = new FontAwesome.Sharp.IconButton();
            this.changePassBtn = new FontAwesome.Sharp.IconButton();
            this.idBtn = new FontAwesome.Sharp.IconButton();
            this.informationBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelInfomationSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.BackColor = System.Drawing.Color.AliceBlue;
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(207, 0);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(800, 576);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1076, 675);
            this.panelChildForm.TabIndex = 2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.panelMenu.Controls.Add(this.signOutBtn);
            this.panelMenu.Controls.Add(this.MessageBtn);
            this.panelMenu.Controls.Add(this.articleManagementBtn);
            this.panelMenu.Controls.Add(this.panelInfomationSubmenu);
            this.panelMenu.Controls.Add(this.informationBtn);
            this.panelMenu.Controls.Add(this.homeBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 675);
            this.panelMenu.TabIndex = 0;
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.signOutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.signOutBtn.FlatAppearance.BorderSize = 0;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.signOutBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signOutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.signOutBtn.IconSize = 45;
            this.signOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutBtn.Location = new System.Drawing.Point(0, 622);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.signOutBtn.Size = new System.Drawing.Size(207, 64);
            this.signOutBtn.TabIndex = 6;
            this.signOutBtn.Text = "Đăng xuất";
            this.signOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.signOutBtn.UseVisualStyleBackColor = false;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // MessageBtn
            // 
            this.MessageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.MessageBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MessageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageBtn.FlatAppearance.BorderSize = 0;
            this.MessageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBtn.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.MessageBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MessageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MessageBtn.IconSize = 45;
            this.MessageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageBtn.Location = new System.Drawing.Point(0, 558);
            this.MessageBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.MessageBtn.Size = new System.Drawing.Size(207, 64);
            this.MessageBtn.TabIndex = 5;
            this.MessageBtn.Text = "Liên hệ";
            this.MessageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MessageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MessageBtn.UseVisualStyleBackColor = false;
            this.MessageBtn.Click += new System.EventHandler(this.MessageBtn_Click);
            // 
            // articleManagementBtn
            // 
            this.articleManagementBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.articleManagementBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.articleManagementBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.articleManagementBtn.FlatAppearance.BorderSize = 0;
            this.articleManagementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.articleManagementBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articleManagementBtn.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.articleManagementBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.articleManagementBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.articleManagementBtn.IconSize = 45;
            this.articleManagementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.articleManagementBtn.Location = new System.Drawing.Point(0, 494);
            this.articleManagementBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.articleManagementBtn.Name = "articleManagementBtn";
            this.articleManagementBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.articleManagementBtn.Size = new System.Drawing.Size(207, 64);
            this.articleManagementBtn.TabIndex = 4;
            this.articleManagementBtn.Text = "Quản lí bài đăng";
            this.articleManagementBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.articleManagementBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.articleManagementBtn.UseVisualStyleBackColor = false;
            this.articleManagementBtn.Click += new System.EventHandler(this.articleManagementBtn_Click);
            // 
            // panelInfomationSubmenu
            // 
            this.panelInfomationSubmenu.Controls.Add(this.infomationChangeBtn);
            this.panelInfomationSubmenu.Controls.Add(this.changePhoneBtn);
            this.panelInfomationSubmenu.Controls.Add(this.changePassBtn);
            this.panelInfomationSubmenu.Controls.Add(this.idBtn);
            this.panelInfomationSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfomationSubmenu.Location = new System.Drawing.Point(0, 279);
            this.panelInfomationSubmenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInfomationSubmenu.Name = "panelInfomationSubmenu";
            this.panelInfomationSubmenu.Size = new System.Drawing.Size(207, 215);
            this.panelInfomationSubmenu.TabIndex = 3;
            // 
            // infomationChangeBtn
            // 
            this.infomationChangeBtn.BackColor = System.Drawing.Color.LightGreen;
            this.infomationChangeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.infomationChangeBtn.FlatAppearance.BorderSize = 0;
            this.infomationChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infomationChangeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infomationChangeBtn.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.infomationChangeBtn.IconColor = System.Drawing.Color.Black;
            this.infomationChangeBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.infomationChangeBtn.IconSize = 30;
            this.infomationChangeBtn.Location = new System.Drawing.Point(0, 162);
            this.infomationChangeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infomationChangeBtn.Name = "infomationChangeBtn";
            this.infomationChangeBtn.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.infomationChangeBtn.Size = new System.Drawing.Size(207, 54);
            this.infomationChangeBtn.TabIndex = 3;
            this.infomationChangeBtn.Text = "Đổi thông tin cá nhân";
            this.infomationChangeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.infomationChangeBtn.UseVisualStyleBackColor = false;
            this.infomationChangeBtn.Click += new System.EventHandler(this.infomationChangeBtn_Click);
            // 
            // changePhoneBtn
            // 
            this.changePhoneBtn.BackColor = System.Drawing.Color.LightGreen;
            this.changePhoneBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePhoneBtn.FlatAppearance.BorderSize = 0;
            this.changePhoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePhoneBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhoneBtn.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.changePhoneBtn.IconColor = System.Drawing.Color.Black;
            this.changePhoneBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.changePhoneBtn.IconSize = 30;
            this.changePhoneBtn.Location = new System.Drawing.Point(0, 108);
            this.changePhoneBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changePhoneBtn.Name = "changePhoneBtn";
            this.changePhoneBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.changePhoneBtn.Size = new System.Drawing.Size(207, 54);
            this.changePhoneBtn.TabIndex = 2;
            this.changePhoneBtn.Text = "Đổi số điện thoại";
            this.changePhoneBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePhoneBtn.UseVisualStyleBackColor = false;
            this.changePhoneBtn.Click += new System.EventHandler(this.changePhoneBtn_Click);
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackColor = System.Drawing.Color.LightGreen;
            this.changePassBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassBtn.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.changePassBtn.IconColor = System.Drawing.Color.Black;
            this.changePassBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.changePassBtn.IconSize = 30;
            this.changePassBtn.Location = new System.Drawing.Point(0, 54);
            this.changePassBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.changePassBtn.Size = new System.Drawing.Size(207, 54);
            this.changePassBtn.TabIndex = 1;
            this.changePassBtn.Text = "Đổi mật khẩu";
            this.changePassBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // idBtn
            // 
            this.idBtn.BackColor = System.Drawing.Color.LightGreen;
            this.idBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.idBtn.FlatAppearance.BorderSize = 0;
            this.idBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtn.IconChar = FontAwesome.Sharp.IconChar.Portrait;
            this.idBtn.IconColor = System.Drawing.Color.Black;
            this.idBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.idBtn.IconSize = 30;
            this.idBtn.Location = new System.Drawing.Point(0, 0);
            this.idBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idBtn.Name = "idBtn";
            this.idBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.idBtn.Size = new System.Drawing.Size(207, 54);
            this.idBtn.TabIndex = 0;
            this.idBtn.Text = "Thông tin cá nhân";
            this.idBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.idBtn.UseVisualStyleBackColor = false;
            this.idBtn.Click += new System.EventHandler(this.idBtn_Click);
            // 
            // informationBtn
            // 
            this.informationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.informationBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.informationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationBtn.FlatAppearance.BorderSize = 0;
            this.informationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationBtn.IconChar = FontAwesome.Sharp.IconChar.GrinAlt;
            this.informationBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.informationBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.informationBtn.IconSize = 45;
            this.informationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informationBtn.Location = new System.Drawing.Point(0, 215);
            this.informationBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.informationBtn.Name = "informationBtn";
            this.informationBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.informationBtn.Size = new System.Drawing.Size(207, 64);
            this.informationBtn.TabIndex = 2;
            this.informationBtn.Text = "Cá nhân";
            this.informationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.informationBtn.UseVisualStyleBackColor = false;
            this.informationBtn.Click += new System.EventHandler(this.informationBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.homeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 45;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 151);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.homeBtn.Size = new System.Drawing.Size(207, 64);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Trang chủ";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 151);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PBL3.Properties.Resources.icons8_customer_96;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::PBL3.Properties.Resources.Tìm_trọ__3_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1076, 675);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CustomerMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1285, 683);
            this.Name = "CustomerMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Main Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelChildForm.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelInfomationSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton signOutBtn;
        private FontAwesome.Sharp.IconButton MessageBtn;
        private FontAwesome.Sharp.IconButton articleManagementBtn;
        private System.Windows.Forms.Panel panelInfomationSubmenu;
        private FontAwesome.Sharp.IconButton changePhoneBtn;
        private FontAwesome.Sharp.IconButton changePassBtn;
        private FontAwesome.Sharp.IconButton idBtn;
        private FontAwesome.Sharp.IconButton informationBtn;
        private FontAwesome.Sharp.IconButton infomationChangeBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}