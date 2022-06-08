
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
            this.saveBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.phoneTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.addressTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.nameTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
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
            this.customPanel1.Controls.Add(this.saveBtn);
            this.customPanel1.Controls.Add(this.phoneTextbox);
            this.customPanel1.Controls.Add(this.addressTextbox);
            this.customPanel1.Controls.Add(this.nameTextbox);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(171, 102);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(958, 481);
            this.customPanel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundColor = System.Drawing.Color.Green;
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 10;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(727, 395);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(171, 55);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextbox.BackColor = System.Drawing.Color.Azure;
            this.phoneTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.phoneTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.phoneTextbox.BorderRadius = 10;
            this.phoneTextbox.BorderSize = 2;
            this.phoneTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.phoneTextbox.Location = new System.Drawing.Point(298, 289);
            this.phoneTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneTextbox.Multiline = true;
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Padding = new System.Windows.Forms.Padding(30, 6, 10, 6);
            this.phoneTextbox.PasswordChar = false;
            this.phoneTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneTextbox.PlaceholderText = "Nhập số điện thoại mới ";
            this.phoneTextbox.Size = new System.Drawing.Size(600, 44);
            this.phoneTextbox.TabIndex = 17;
            this.phoneTextbox.Texts = "";
            this.phoneTextbox.UnderlinedStyle = false;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextbox.BackColor = System.Drawing.Color.Azure;
            this.addressTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.addressTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.addressTextbox.BorderRadius = 10;
            this.addressTextbox.BorderSize = 2;
            this.addressTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.addressTextbox.Location = new System.Drawing.Point(298, 208);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.addressTextbox.Multiline = true;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Padding = new System.Windows.Forms.Padding(30, 6, 10, 6);
            this.addressTextbox.PasswordChar = false;
            this.addressTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.addressTextbox.PlaceholderText = "Nhập địa chỉ";
            this.addressTextbox.Size = new System.Drawing.Size(600, 44);
            this.addressTextbox.TabIndex = 16;
            this.addressTextbox.Texts = "";
            this.addressTextbox.UnderlinedStyle = false;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextbox.BackColor = System.Drawing.Color.Azure;
            this.nameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.nameTextbox.BorderFocusColor = System.Drawing.Color.DarkOrchid;
            this.nameTextbox.BorderRadius = 10;
            this.nameTextbox.BorderSize = 2;
            this.nameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.nameTextbox.Location = new System.Drawing.Point(298, 122);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Padding = new System.Windows.Forms.Padding(30, 6, 10, 6);
            this.nameTextbox.PasswordChar = false;
            this.nameTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTextbox.PlaceholderText = "Nhập tên hiển thị";
            this.nameTextbox.Size = new System.Drawing.Size(600, 44);
            this.nameTextbox.TabIndex = 15;
            this.nameTextbox.Texts = "";
            this.nameTextbox.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số điện thoại : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa chỉ : ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 45);
            this.label2.TabIndex = 11;
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
            this.customPanel2.Size = new System.Drawing.Size(958, 77);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(189, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN CÁ NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InformationUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1296, 789);
            this.Controls.Add(this.customPanel1);
            this.DoubleBuffered = true;
            this.Name = "InformationUpdateForm";
            this.Text = "InformationUpdateForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private CustomComponents.CustomButton saveBtn;
        private CustomComponents.CustomTextBox phoneTextbox;
        private CustomComponents.CustomTextBox addressTextbox;
        private CustomComponents.CustomTextBox nameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}