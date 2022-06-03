﻿
namespace PBL3.Views.AdminForms
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
            this.label3 = new System.Windows.Forms.Label();
            this.postedFilterCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.deleteBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.confirmBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.readBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.trangThaiThueCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lọc theo trạng thái đã phê duyệt";
            // 
            // postedFilterCbb
            // 
            this.postedFilterCbb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postedFilterCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.postedFilterCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postedFilterCbb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.postedFilterCbb.BorderSize = 3;
            this.postedFilterCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.postedFilterCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.postedFilterCbb.ForeColor = System.Drawing.Color.DimGray;
            this.postedFilterCbb.IconColor = System.Drawing.Color.Green;
            this.postedFilterCbb.Items.AddRange(new object[] {
            "Đã duyệt",
            "Chưa duyệt"});
            this.postedFilterCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.postedFilterCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.postedFilterCbb.Location = new System.Drawing.Point(243, 12);
            this.postedFilterCbb.MinimumSize = new System.Drawing.Size(200, 33);
            this.postedFilterCbb.Name = "postedFilterCbb";
            this.postedFilterCbb.Padding = new System.Windows.Forms.Padding(3);
            this.postedFilterCbb.Size = new System.Drawing.Size(200, 33);
            this.postedFilterCbb.TabIndex = 18;
            this.postedFilterCbb.Texts = "";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.Green;
            this.deleteBtn.BackgroundColor = System.Drawing.Color.Green;
            this.deleteBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteBtn.BorderRadius = 10;
            this.deleteBtn.BorderSize = 0;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(287, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 41);
            this.deleteBtn.TabIndex = 17;
            this.deleteBtn.Text = "Xoá bài đăng";
            this.deleteBtn.TextColor = System.Drawing.Color.White;
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmBtn.BackColor = System.Drawing.Color.Green;
            this.confirmBtn.BackgroundColor = System.Drawing.Color.Green;
            this.confirmBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.confirmBtn.BorderRadius = 10;
            this.confirmBtn.BorderSize = 0;
            this.confirmBtn.FlatAppearance.BorderSize = 0;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(701, 13);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(156, 41);
            this.confirmBtn.TabIndex = 16;
            this.confirmBtn.Text = "Duyệt bài đăng";
            this.confirmBtn.TextColor = System.Drawing.Color.White;
            this.confirmBtn.UseVisualStyleBackColor = false;
            // 
            // readBtn
            // 
            this.readBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.readBtn.BackColor = System.Drawing.Color.Green;
            this.readBtn.BackgroundColor = System.Drawing.Color.Green;
            this.readBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.readBtn.BorderRadius = 10;
            this.readBtn.BorderSize = 0;
            this.readBtn.FlatAppearance.BorderSize = 0;
            this.readBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.ForeColor = System.Drawing.Color.White;
            this.readBtn.Location = new System.Drawing.Point(489, 13);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(156, 41);
            this.readBtn.TabIndex = 15;
            this.readBtn.Text = "Xem bài đăng";
            this.readBtn.TextColor = System.Drawing.Color.White;
            this.readBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 10;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(887, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(202, 41);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 13;
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
            this.trangThaiThueCbb.Location = new System.Drawing.Point(643, 12);
            this.trangThaiThueCbb.MinimumSize = new System.Drawing.Size(200, 33);
            this.trangThaiThueCbb.Name = "trangThaiThueCbb";
            this.trangThaiThueCbb.Padding = new System.Windows.Forms.Padding(3);
            this.trangThaiThueCbb.Size = new System.Drawing.Size(200, 33);
            this.trangThaiThueCbb.TabIndex = 12;
            this.trangThaiThueCbb.Texts = "";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AliceBlue;
            this.panelMenu.Controls.Add(this.deleteBtn);
            this.panelMenu.Controls.Add(this.readBtn);
            this.panelMenu.Controls.Add(this.confirmBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 597);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1112, 66);
            this.panelMenu.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.trangThaiThueCbb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.postedFilterCbb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 64);
            this.panel1.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 533);
            this.dataGridView1.TabIndex = 21;
            // 
            // ArticleManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Name = "ArticleManagementForm";
            this.Text = "ArticleManagementForm";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private CustomComponents.CustomComboBox postedFilterCbb;
        private CustomComponents.CustomButton deleteBtn;
        private CustomComponents.CustomButton confirmBtn;
        private CustomComponents.CustomButton readBtn;
        private CustomComponents.CustomButton searchBtn;
        private System.Windows.Forms.Label label2;
        private CustomComponents.CustomComboBox trangThaiThueCbb;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}