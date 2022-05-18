
namespace PBL3.Views.CustomerForm
{
    partial class InformationUpdateForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.zaloTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.facebookTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.addressTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.usernameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customPanel3 = new PBL3.Views.CustomComponents.CustomPanel();
            this.saveBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
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
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(171, 102);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(958, 628);
            this.customPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.zaloTextbox);
            this.panel1.Controls.Add(this.facebookTextbox);
            this.panel1.Controls.Add(this.addressTextbox);
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 530);
            this.panel1.TabIndex = 2;
            // 
            // zaloTextbox
            // 
            this.zaloTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zaloTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.zaloTextbox.BorderColor = System.Drawing.Color.Blue;
            this.zaloTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.zaloTextbox.BorderRadius = 10;
            this.zaloTextbox.BorderSize = 2;
            this.zaloTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaloTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.zaloTextbox.Location = new System.Drawing.Point(303, 332);
            this.zaloTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.zaloTextbox.Multiline = false;
            this.zaloTextbox.Name = "zaloTextbox";
            this.zaloTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.zaloTextbox.PasswordChar = false;
            this.zaloTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.zaloTextbox.PlaceholderText = "Nhập link zalo";
            this.zaloTextbox.Size = new System.Drawing.Size(600, 45);
            this.zaloTextbox.TabIndex = 8;
            this.zaloTextbox.Texts = "";
            this.zaloTextbox.UnderlinedStyle = false;
            // 
            // facebookTextbox
            // 
            this.facebookTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.facebookTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.facebookTextbox.BorderColor = System.Drawing.Color.Blue;
            this.facebookTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.facebookTextbox.BorderRadius = 10;
            this.facebookTextbox.BorderSize = 2;
            this.facebookTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facebookTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.facebookTextbox.Location = new System.Drawing.Point(303, 242);
            this.facebookTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.facebookTextbox.Multiline = false;
            this.facebookTextbox.Name = "facebookTextbox";
            this.facebookTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.facebookTextbox.PasswordChar = false;
            this.facebookTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.facebookTextbox.PlaceholderText = "Nhập link facebook";
            this.facebookTextbox.Size = new System.Drawing.Size(600, 45);
            this.facebookTextbox.TabIndex = 7;
            this.facebookTextbox.Texts = "";
            this.facebookTextbox.UnderlinedStyle = false;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.addressTextbox.BorderColor = System.Drawing.Color.Blue;
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.addressTextbox.BorderRadius = 10;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.addressTextbox.Location = new System.Drawing.Point(303, 140);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextbox.Multiline = false;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.addressTextbox.PlaceholderText = "Nhập địa chỉ";
            this.addressTextbox.Size = new System.Drawing.Size(600, 45);
            this.addressTextbox.TabIndex = 6;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.usernameTextbox.BorderColor = System.Drawing.Color.Blue;
            this.usernameTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.usernameTextbox.BorderRadius = 10;
            this.usernameTextbox.BorderSize = 2;
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTextbox.Location = new System.Drawing.Point(303, 52);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Multiline = false;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Padding = new System.Windows.Forms.Padding(30, 7, 10, 7);
            this.usernameTextbox.PasswordChar = false;
            this.usernameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTextbox.PlaceholderText = "Nhập tên hiển thị";
            this.usernameTextbox.Size = new System.Drawing.Size(600, 45);
            this.usernameTextbox.TabIndex = 5;
            this.usernameTextbox.Texts = "";
            this.usernameTextbox.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zalo : ";
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
            this.customPanel3.Location = new System.Drawing.Point(0, 440);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(958, 90);
            this.customPanel3.TabIndex = 3;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundColor = System.Drawing.Color.Green;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(366, 16);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(206, 54);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Lưu thông tin";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Facebook : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị : ";
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
            this.customPanel2.Size = new System.Drawing.Size(958, 106);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(207, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 836);
            this.Controls.Add(this.customPanel1);
            this.Name = "InformationUpdateForm";
            this.Text = "InformationUpdateForm";
            this.customPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private CustomComponents.CustomPanel customPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton saveBtn;
        private CustomComponents.CustomTextBox zaloTextbox;
        private CustomComponents.CustomTextBox facebookTextbox;
        private CustomComponents.CustomTextBox addressTextbox;
        private CustomComponents.CustomTextBox usernameTextbox;
    }
}