
namespace PBL3.Views.CommonForm
{
    partial class LoginForm
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
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.forgotPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.usernameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(189, 69);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(652, 417);
            this.customPanel1.TabIndex = 0;
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
            this.customPanel2.Size = new System.Drawing.Size(652, 68);
            this.customPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(150, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.forgotPassLinkLabel);
            this.panel1.Controls.Add(this.signUpLinkLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.passwordTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 417);
            this.panel1.TabIndex = 7;
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
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(129, 290);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(400, 33);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotPassLinkLabel
            // 
            this.forgotPassLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPassLinkLabel.AutoSize = true;
            this.forgotPassLinkLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.forgotPassLinkLabel.Location = new System.Drawing.Point(424, 245);
            this.forgotPassLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotPassLinkLabel.Name = "forgotPassLinkLabel";
            this.forgotPassLinkLabel.Size = new System.Drawing.Size(105, 17);
            this.forgotPassLinkLabel.TabIndex = 4;
            this.forgotPassLinkLabel.TabStop = true;
            this.forgotPassLinkLabel.Text = "Quên mật khẩu ?";
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.signUpLinkLabel.Location = new System.Drawing.Point(281, 369);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(87, 17);
            this.signUpLinkLabel.TabIndex = 6;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Đăng ký ngay";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(266, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chưa có tài khoản ?";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.passwordTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.passwordTextbox.BorderRadius = 10;
            this.passwordTextbox.BorderSize = 2;
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextbox.Location = new System.Drawing.Point(129, 196);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Multiline = false;
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.passwordTextbox.PasswordChar = true;
            this.passwordTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextbox.PlaceholderText = "Password";
            this.passwordTextbox.Size = new System.Drawing.Size(400, 29);
            this.passwordTextbox.TabIndex = 2;
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
            this.usernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.Location = new System.Drawing.Point(129, 132);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Padding = new System.Windows.Forms.Padding(20, 4, 7, 4);
            this.usernameTextbox.PasswordChar = false;
            this.usernameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTextbox.PlaceholderText = "Username";
            this.usernameTextbox.Size = new System.Drawing.Size(400, 29);
            this.usernameTextbox.TabIndex = 7;
            this.usernameTextbox.Texts = "";
            this.usernameTextbox.UnderlinedStyle = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 627);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(666, 497);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextBox passwordTextbox;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel forgotPassLinkLabel;
        private CustomComponents.CustomButton loginBtn;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomTextBox usernameTextbox;
    }
}