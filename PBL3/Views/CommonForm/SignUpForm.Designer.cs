
namespace PBL3.Views.CommonForm
{
    partial class SignUpForm
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
            this.customPanel1 = new PBL3.Views.CustomComponents.CustomPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.renterBtn = new PBL3.Views.CustomComponents.CustomRadioButton();
            this.hostBtn = new PBL3.Views.CustomComponents.CustomRadioButton();
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.passwordTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.usernameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.phoneNumberTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.nameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.customPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.Controls.Add(this.groupBox1);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.Controls.Add(this.signUpLinkLabel);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.loginBtn);
            this.customPanel1.Controls.Add(this.passwordTextbox);
            this.customPanel1.Controls.Add(this.usernameTextbox);
            this.customPanel1.Controls.Add(this.phoneNumberTextbox);
            this.customPanel1.Controls.Add(this.nameTextbox);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.White;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(171, 24);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(684, 547);
            this.customPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.renterBtn);
            this.groupBox1.Controls.Add(this.hostBtn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(151, 307);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(396, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn là ";
            // 
            // renterBtn
            // 
            this.renterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renterBtn.AutoSize = true;
            this.renterBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.renterBtn.Location = new System.Drawing.Point(231, 29);
            this.renterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.renterBtn.MinimumSize = new System.Drawing.Size(0, 13);
            this.renterBtn.Name = "renterBtn";
            this.renterBtn.Size = new System.Drawing.Size(114, 24);
            this.renterBtn.TabIndex = 1;
            this.renterBtn.TabStop = true;
            this.renterBtn.Text = "Người thuê";
            this.renterBtn.UncheckedColor = System.Drawing.Color.Gray;
            this.renterBtn.UseVisualStyleBackColor = true;
            // 
            // hostBtn
            // 
            this.hostBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hostBtn.AutoSize = true;
            this.hostBtn.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.hostBtn.Location = new System.Drawing.Point(55, 29);
            this.hostBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hostBtn.MinimumSize = new System.Drawing.Size(0, 13);
            this.hostBtn.Name = "hostBtn";
            this.hostBtn.Size = new System.Drawing.Size(87, 24);
            this.hostBtn.TabIndex = 0;
            this.hostBtn.TabStop = true;
            this.hostBtn.Text = "Chủ trọ";
            this.hostBtn.UncheckedColor = System.Drawing.Color.Gray;
            this.hostBtn.UseVisualStyleBackColor = true;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 0;
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel2.Location = new System.Drawing.Point(0, 0);
            this.customPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(684, 67);
            this.customPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(147, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.signUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signUpLinkLabel.Location = new System.Drawing.Point(288, 480);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(94, 15);
            this.signUpLinkLabel.TabIndex = 9;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Đăng nhập ngay";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.label3.Location = new System.Drawing.Point(151, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bạn đã có tài khoản ?";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.2F);
            this.label2.Location = new System.Drawing.Point(151, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bạn nhấn vào nút đăng ký tức là bạn đồng ý với điều khoản của chúng tôi";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.loginBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginBtn.BorderRadius = 10;
            this.loginBtn.BorderSize = 0;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(147, 394);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(400, 33);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Tạo tài khoản";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.passwordTextbox.BorderRadius = 10;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextbox.Location = new System.Drawing.Point(147, 260);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.passwordTextbox.PasswordChar = true;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.Size = new System.Drawing.Size(400, 29);
            this.passwordTextbox.TabIndex = 5;
            this.passwordTextbox.Texts = "";
            this.passwordTextbox.UnderlinedStyle = false;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.usernameTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.usernameTextbox.BorderRadius = 10;
            this.usernameTextbox.BorderSize = 2;
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.Location = new System.Drawing.Point(147, 205);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.usernameTextbox.PasswordChar = false;
            this.usernameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.Size = new System.Drawing.Size(400, 29);
            this.usernameTextbox.TabIndex = 4;
            this.usernameTextbox.Texts = "";
            this.usernameTextbox.UnderlinedStyle = false;
            // 
            // phoneNumberTextbox
            // 
            this.phoneNumberTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumberTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.phoneNumberTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.phoneNumberTextbox.BorderRadius = 10;
            this.phoneNumberTextbox.BorderSize = 2;
            this.phoneNumberTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneNumberTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumberTextbox.Location = new System.Drawing.Point(147, 152);
            this.phoneNumberTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumberTextbox.Multiline = false;
            this.phoneNumberTextbox.Name = "phoneNumberTextbox";
            this.phoneNumberTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.phoneNumberTextbox.PasswordChar = false;
            this.phoneNumberTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumberTextbox.PlaceholderText = "Số điện thoại";
            this.phoneNumberTextbox.Size = new System.Drawing.Size(400, 29);
            this.phoneNumberTextbox.TabIndex = 3;
            this.phoneNumberTextbox.Texts = "";
            this.phoneNumberTextbox.UnderlinedStyle = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.nameTextbox.Location = new System.Drawing.Point(147, 100);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.Multiline = false;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTextbox.PlaceholderText = "Họ tên";
            this.nameTextbox.Size = new System.Drawing.Size(400, 29);
            this.nameTextbox.TabIndex = 2;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 586);
            this.Controls.Add(this.customPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(539, 401);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CustomComponents.CustomTextBox nameTextbox;
        private CustomComponents.CustomTextBox phoneNumberTextbox;
        private CustomComponents.CustomTextBox usernameTextbox;
        private CustomComponents.CustomTextBox passwordTextbox;
        private CustomComponents.CustomButton loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomComponents.CustomRadioButton renterBtn;
        private CustomComponents.CustomRadioButton hostBtn;
    }
}