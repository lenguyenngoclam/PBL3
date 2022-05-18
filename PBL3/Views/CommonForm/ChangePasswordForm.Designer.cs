
namespace PBL3.Views.CommonForm
{
    partial class ChangePasswordForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oldPassTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.newPassTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.confirmNewPassField = new PBL3.Views.CustomComponents.CustomTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel3 = new PBL3.Views.CustomComponents.CustomPanel();
            this.saveBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
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
            this.customPanel1.Location = new System.Drawing.Point(153, 62);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1176, 642);
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
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1176, 106);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(316, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cũ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác nhận mật khẩu mới : ";
            // 
            // oldPassTextbox
            // 
            this.oldPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oldPassTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.oldPassTextbox.BorderColor = System.Drawing.Color.Blue;
            this.oldPassTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.oldPassTextbox.BorderRadius = 10;
            this.oldPassTextbox.BorderSize = 2;
            this.oldPassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPassTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.oldPassTextbox.Location = new System.Drawing.Point(463, 47);
            this.oldPassTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.oldPassTextbox.Multiline = false;
            this.oldPassTextbox.Name = "oldPassTextbox";
            this.oldPassTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.oldPassTextbox.PasswordChar = false;
            this.oldPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.oldPassTextbox.PlaceholderText = "Nhập mật khẩu cũ";
            this.oldPassTextbox.Size = new System.Drawing.Size(600, 47);
            this.oldPassTextbox.TabIndex = 5;
            this.oldPassTextbox.Texts = "";
            this.oldPassTextbox.UnderlinedStyle = false;
            // 
            // newPassTextbox
            // 
            this.newPassTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPassTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.newPassTextbox.BorderColor = System.Drawing.Color.Blue;
            this.newPassTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.newPassTextbox.BorderRadius = 10;
            this.newPassTextbox.BorderSize = 2;
            this.newPassTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.newPassTextbox.Location = new System.Drawing.Point(463, 135);
            this.newPassTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.newPassTextbox.Multiline = false;
            this.newPassTextbox.Name = "newPassTextbox";
            this.newPassTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.newPassTextbox.PasswordChar = true;
            this.newPassTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.newPassTextbox.PlaceholderText = "Nhập mật khẩu mới";
            this.newPassTextbox.Size = new System.Drawing.Size(600, 47);
            this.newPassTextbox.TabIndex = 6;
            this.newPassTextbox.Texts = "";
            this.newPassTextbox.UnderlinedStyle = false;
            // 
            // confirmNewPassField
            // 
            this.confirmNewPassField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmNewPassField.BackColor = System.Drawing.SystemColors.Window;
            this.confirmNewPassField.BorderColor = System.Drawing.Color.Blue;
            this.confirmNewPassField.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.confirmNewPassField.BorderRadius = 10;
            this.confirmNewPassField.BorderSize = 2;
            this.confirmNewPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPassField.ForeColor = System.Drawing.Color.DimGray;
            this.confirmNewPassField.Location = new System.Drawing.Point(463, 221);
            this.confirmNewPassField.Margin = new System.Windows.Forms.Padding(4);
            this.confirmNewPassField.Multiline = false;
            this.confirmNewPassField.Name = "confirmNewPassField";
            this.confirmNewPassField.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.confirmNewPassField.PasswordChar = true;
            this.confirmNewPassField.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.confirmNewPassField.PlaceholderText = "Xác nhận mật khẩu mới";
            this.confirmNewPassField.Size = new System.Drawing.Size(600, 47);
            this.confirmNewPassField.TabIndex = 7;
            this.confirmNewPassField.Texts = "";
            this.confirmNewPassField.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.oldPassTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.confirmNewPassField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.newPassTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 530);
            this.panel1.TabIndex = 9;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 0;
            this.customPanel3.Controls.Add(this.saveBtn);
            this.customPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientBottonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.customPanel3.Location = new System.Drawing.Point(0, 446);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(1170, 84);
            this.customPanel3.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundColor = System.Drawing.Color.Green;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(494, 13);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(200, 54);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Đổi mật khẩu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 788);
            this.Controls.Add(this.customPanel1);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomTextBox confirmNewPassField;
        private CustomComponents.CustomTextBox newPassTextbox;
        private CustomComponents.CustomTextBox oldPassTextbox;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomPanel customPanel3;
        private CustomComponents.CustomButton saveBtn;
    }
}