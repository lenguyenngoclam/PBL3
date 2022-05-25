
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customPanel1 = new PBL3.Views.CustomComponents.CustomPanel();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.uploadBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.updateBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trangThaiThueCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maBai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customPanel2 = new PBL3.Views.CustomComponents.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.customPanel1.Controls.Add(this.deleteBtn);
            this.customPanel1.Controls.Add(this.uploadBtn);
            this.customPanel1.Controls.Add(this.updateBtn);
            this.customPanel1.Controls.Add(this.readBtn);
            this.customPanel1.Controls.Add(this.searchBtn);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.trangThaiThueCbb);
            this.customPanel1.Controls.Add(this.dataGridView1);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientBottonColor = System.Drawing.Color.Azure;
            this.customPanel1.GradientTopColor = System.Drawing.Color.Azure;
            this.customPanel1.Location = new System.Drawing.Point(41, 12);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1582, 910);
            this.customPanel1.TabIndex = 0;
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
            this.deleteBtn.Location = new System.Drawing.Point(405, 823);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(212, 52);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Xoá bài đăng";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
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
            this.uploadBtn.Location = new System.Drawing.Point(1315, 823);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(212, 52);
            this.uploadBtn.TabIndex = 8;
            this.uploadBtn.Text = "Đăng bài";
            this.uploadBtn.TextColor = System.Drawing.Color.White;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
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
            this.updateBtn.Location = new System.Drawing.Point(1015, 823);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(212, 52);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Cập nhật bài đăng";
            this.updateBtn.TextColor = System.Drawing.Color.White;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.readBtn.Location = new System.Drawing.Point(715, 823);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(212, 52);
            this.readBtn.TabIndex = 6;
            this.readBtn.Text = "Xem bài đăng";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
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
            this.searchBtn.Location = new System.Drawing.Point(1247, 181);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(280, 52);
            this.searchBtn.TabIndex = 5;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(886, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lọc theo trạng thái thuê";
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
            this.trangThaiThueCbb.Location = new System.Drawing.Point(857, 181);
            this.trangThaiThueCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.trangThaiThueCbb.Name = "trangThaiThueCbb";
            this.trangThaiThueCbb.Padding = new System.Windows.Forms.Padding(3);
            this.trangThaiThueCbb.Size = new System.Drawing.Size(300, 52);
            this.trangThaiThueCbb.TabIndex = 3;
            this.trangThaiThueCbb.Texts = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBai,
            this.linkAnh,
            this.tieuDe,
            this.gia,
            this.dienTich,
            this.ngayDang,
            this.khuVuc,
            this.trangThaiThue});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(50, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1490, 414);
            this.dataGridView1.TabIndex = 2;
            // 
            // maBai
            // 
            this.maBai.HeaderText = "Mã Bài";
            this.maBai.MinimumWidth = 10;
            this.maBai.Name = "maBai";
            this.maBai.Width = 200;
            // 
            // linkAnh
            // 
            this.linkAnh.HeaderText = "Link Ảnh";
            this.linkAnh.MinimumWidth = 10;
            this.linkAnh.Name = "linkAnh";
            this.linkAnh.Width = 200;
            // 
            // tieuDe
            // 
            this.tieuDe.HeaderText = "Tiêu Đề";
            this.tieuDe.MinimumWidth = 10;
            this.tieuDe.Name = "tieuDe";
            this.tieuDe.Width = 200;
            // 
            // gia
            // 
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 10;
            this.gia.Name = "gia";
            this.gia.Width = 200;
            // 
            // dienTich
            // 
            this.dienTich.HeaderText = "Diện Tích";
            this.dienTich.MinimumWidth = 10;
            this.dienTich.Name = "dienTich";
            this.dienTich.Width = 200;
            // 
            // ngayDang
            // 
            this.ngayDang.HeaderText = "Ngày Đăng";
            this.ngayDang.MinimumWidth = 10;
            this.ngayDang.Name = "ngayDang";
            this.ngayDang.Width = 200;
            // 
            // khuVuc
            // 
            this.khuVuc.HeaderText = "Khu Vực";
            this.khuVuc.MinimumWidth = 10;
            this.khuVuc.Name = "khuVuc";
            this.khuVuc.Width = 200;
            // 
            // trangThaiThue
            // 
            this.trangThaiThue.HeaderText = "Trạng Thái Thuê";
            this.trangThaiThue.MinimumWidth = 10;
            this.trangThaiThue.Name = "trangThaiThue";
            this.trangThaiThue.Width = 200;
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
            this.customPanel2.Size = new System.Drawing.Size(1582, 92);
            this.customPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(109)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ TIN ĐĂNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArticleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1656, 962);
            this.Controls.Add(this.customPanel1);
            this.Name = "ArticleManagementForm";
            this.Text = "ArticleManagementForm";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomComponents.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBai;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiThue;
        private CustomComponents.CustomPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomComboBox trangThaiThueCbb;
        private CustomComponents.CustomButton searchBtn;
        private CustomComponents.CustomButton deleteBtn;
        private CustomComponents.CustomButton uploadBtn;
        private CustomComponents.CustomButton updateBtn;
        private CustomComponents.CustomButton readBtn;
    }
}