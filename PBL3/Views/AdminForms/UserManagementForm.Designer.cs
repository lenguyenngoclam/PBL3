
namespace PBL3.Views.AdminForms
{
    partial class UserManagementForm
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
            this.trangThaiThueCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.blockBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messageTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trangThaiThueCbb
            // 
            this.trangThaiThueCbb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trangThaiThueCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.trangThaiThueCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trangThaiThueCbb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.trangThaiThueCbb.BorderSize = 3;
            this.trangThaiThueCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.trangThaiThueCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.trangThaiThueCbb.ForeColor = System.Drawing.Color.DimGray;
            this.trangThaiThueCbb.IconColor = System.Drawing.Color.Green;
            this.trangThaiThueCbb.Items.AddRange(new object[] {
            "100m^2",
            "200m^2"});
            this.trangThaiThueCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.trangThaiThueCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.trangThaiThueCbb.Location = new System.Drawing.Point(654, 24);
            this.trangThaiThueCbb.Margin = new System.Windows.Forms.Padding(2);
            this.trangThaiThueCbb.MinimumSize = new System.Drawing.Size(200, 33);
            this.trangThaiThueCbb.Name = "trangThaiThueCbb";
            this.trangThaiThueCbb.Padding = new System.Windows.Forms.Padding(2);
            this.trangThaiThueCbb.Size = new System.Drawing.Size(200, 33);
            this.trangThaiThueCbb.TabIndex = 3;
            this.trangThaiThueCbb.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 10;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(900, 24);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(187, 31);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // blockBtn
            // 
            this.blockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blockBtn.BackColor = System.Drawing.Color.Green;
            this.blockBtn.BackgroundColor = System.Drawing.Color.Green;
            this.blockBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.blockBtn.BorderRadius = 10;
            this.blockBtn.BorderSize = 0;
            this.blockBtn.FlatAppearance.BorderSize = 0;
            this.blockBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blockBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockBtn.ForeColor = System.Drawing.Color.White;
            this.blockBtn.Location = new System.Drawing.Point(594, 11);
            this.blockBtn.Margin = new System.Windows.Forms.Padding(2);
            this.blockBtn.Name = "blockBtn";
            this.blockBtn.Size = new System.Drawing.Size(187, 42);
            this.blockBtn.TabIndex = 6;
            this.blockBtn.Text = "Chặn tài khoản";
            this.blockBtn.TextColor = System.Drawing.Color.White;
            this.blockBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Green;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(350, 11);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(187, 41);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Xoá tài khoản";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 516);
            this.dataGridView1.TabIndex = 10;
            // 
            // messageTextbox
            // 
            this.messageTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.messageTextbox.AutoSize = true;
            this.messageTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.messageTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.messageTextbox.BorderRadius = 0;
            this.messageTextbox.BorderSize = 2;
            this.messageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.messageTextbox.Location = new System.Drawing.Point(132, 24);
            this.messageTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.messageTextbox.Multiline = false;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.messageTextbox.PasswordChar = false;
            this.messageTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.messageTextbox.PlaceholderText = "";
            this.messageTextbox.Size = new System.Drawing.Size(471, 29);
            this.messageTextbox.TabIndex = 11;
            this.messageTextbox.Texts = "";
            this.messageTextbox.UnderlinedStyle = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.blockBtn);
            this.panelMenu.Controls.Add(this.deleteBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 599);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1109, 66);
            this.panelMenu.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.messageTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trangThaiThueCbb);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 83);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(209)))), ((int)(((byte)(166)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 665);
            this.panel2.TabIndex = 15;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1109, 665);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomComponents.CustomComboBox trangThaiThueCbb;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomButton searchBtn;
        private CustomComponents.CustomButton blockBtn;
        private CustomComponents.CustomButton deleteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomComponents.CustomTextBox messageTextbox;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}