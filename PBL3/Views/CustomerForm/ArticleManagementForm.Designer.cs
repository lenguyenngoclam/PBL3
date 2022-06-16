
namespace PBL3.Views.CustomerForm
{
    partial class ArticleManagementForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.trangThaiThueCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.uploadBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.trangThaiThueCbb);
            this.panelMenu.Controls.Add(this.searchBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1656, 97);
            this.panelMenu.TabIndex = 19;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 20;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1232, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(280, 52);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // trangThaiThueCbb
            // 
            this.trangThaiThueCbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trangThaiThueCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.trangThaiThueCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trangThaiThueCbb.BorderColor = System.Drawing.Color.MediumSlateBlue;
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
            this.trangThaiThueCbb.Location = new System.Drawing.Point(489, 17);
            this.trangThaiThueCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.trangThaiThueCbb.Name = "trangThaiThueCbb";
            this.trangThaiThueCbb.Padding = new System.Windows.Forms.Padding(3);
            this.trangThaiThueCbb.Size = new System.Drawing.Size(300, 52);
            this.trangThaiThueCbb.TabIndex = 11;
            this.trangThaiThueCbb.Texts = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lọc theo trạng thái thuê";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.readBtn);
            this.panel1.Controls.Add(this.uploadBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 865);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1656, 97);
            this.panel1.TabIndex = 20;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.BackColor = System.Drawing.Color.Green;
            this.updateBtn.BackgroundColor = System.Drawing.Color.Green;
            this.updateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateBtn.BorderRadius = 20;
            this.updateBtn.BorderSize = 0;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(864, 22);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(212, 52);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Cập nhật bài đăng";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadBtn.BackColor = System.Drawing.Color.Green;
            this.uploadBtn.BackgroundColor = System.Drawing.Color.Green;
            this.uploadBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.uploadBtn.BorderRadius = 20;
            this.uploadBtn.BorderSize = 0;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(1326, 22);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(212, 52);
            this.uploadBtn.TabIndex = 16;
            this.uploadBtn.Text = "Đăng bài";
            this.uploadBtn.TextColor = System.Drawing.Color.White;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // readBtn
            // 
            this.readBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readBtn.BackColor = System.Drawing.Color.Green;
            this.readBtn.BackgroundColor = System.Drawing.Color.Green;
            this.readBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.readBtn.BorderRadius = 20;
            this.readBtn.BorderSize = 0;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(534, 22);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(212, 52);
            this.readBtn.TabIndex = 14;
            this.readBtn.Text = "Xem bài đăng";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Green;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 20;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(200, 22);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(212, 52);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Xoá bài đăng";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1656, 962);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1656, 768);
            this.dataGridView1.TabIndex = 21;
            // 
            // ArticleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1656, 962);
            this.Controls.Add(this.panel2);
            this.Name = "ArticleManagementForm";
            this.Text = "ArticleManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomComboBox trangThaiThueCbb;
        private CustomComponents.CustomButton searchBtn;
        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomButton deleteBtn;
        private CustomComponents.CustomButton readBtn;
        private CustomComponents.CustomButton uploadBtn;
        private CustomComponents.CustomButton updateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}