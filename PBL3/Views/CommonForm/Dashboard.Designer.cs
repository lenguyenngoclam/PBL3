
namespace PBL3.Views.CommonForm
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextPageBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.prevPageBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.houseInfoComponent5 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent4 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent3 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent2 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.houseInfoComponent1 = new PBL3.Views.CustomComponents.HouseInfoComponent();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customComboBox_phuong = new PBL3.Views.CustomComponents.CustomComboBox();
            this.searchBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.truongCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.dienTichCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.giaCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.quanCbb = new PBL3.Views.CustomComponents.CustomComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.nextPageBtn);
            this.panel1.Controls.Add(this.prevPageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 833);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2154, 100);
            this.panel1.TabIndex = 0;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextPageBtn.BackColor = System.Drawing.Color.Green;
            this.nextPageBtn.BackgroundColor = System.Drawing.Color.Green;
            this.nextPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.nextPageBtn.BorderRadius = 20;
            this.nextPageBtn.BorderSize = 0;
            this.nextPageBtn.FlatAppearance.BorderSize = 0;
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Location = new System.Drawing.Point(1208, 14);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(280, 69);
            this.nextPageBtn.TabIndex = 1;
            this.nextPageBtn.Text = "Trang sau";
            this.nextPageBtn.TextColor = System.Drawing.Color.White;
            this.nextPageBtn.UseVisualStyleBackColor = false;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevPageBtn.BackColor = System.Drawing.Color.Green;
            this.prevPageBtn.BackgroundColor = System.Drawing.Color.Green;
            this.prevPageBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.prevPageBtn.BorderRadius = 20;
            this.prevPageBtn.BorderSize = 0;
            this.prevPageBtn.FlatAppearance.BorderSize = 0;
            this.prevPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevPageBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPageBtn.ForeColor = System.Drawing.Color.White;
            this.prevPageBtn.Location = new System.Drawing.Point(651, 14);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(280, 69);
            this.prevPageBtn.TabIndex = 0;
            this.prevPageBtn.Text = "Trang trước";
            this.prevPageBtn.TextColor = System.Drawing.Color.White;
            this.prevPageBtn.UseVisualStyleBackColor = false;
            this.prevPageBtn.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.houseInfoComponent5);
            this.panel2.Controls.Add(this.houseInfoComponent4);
            this.panel2.Controls.Add(this.houseInfoComponent3);
            this.panel2.Controls.Add(this.houseInfoComponent2);
            this.panel2.Controls.Add(this.houseInfoComponent1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2154, 833);
            this.panel2.TabIndex = 1;
            // 
            // houseInfoComponent5
            // 
            this.houseInfoComponent5.AddressLabel = "Địa chỉ";
            this.houseInfoComponent5.AreaLabel = "Mét vuông";
            this.houseInfoComponent5.DescLabel = "Miêu tả";
            this.houseInfoComponent5.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent5.HomeLink = "Tên nhà";
            this.houseInfoComponent5.Location = new System.Drawing.Point(0, 2082);
            this.houseInfoComponent5.MoneyLabel = "Số tiền";
            this.houseInfoComponent5.Name = "houseInfoComponent5";
            this.houseInfoComponent5.PictureBox = null;
            this.houseInfoComponent5.Size = new System.Drawing.Size(2120, 494);
            this.houseInfoComponent5.TabIndex = 6;
            // 
            // houseInfoComponent4
            // 
            this.houseInfoComponent4.AddressLabel = "Địa chỉ";
            this.houseInfoComponent4.AreaLabel = "Mét vuông";
            this.houseInfoComponent4.DescLabel = "Miêu tả";
            this.houseInfoComponent4.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent4.HomeLink = "Tên nhà";
            this.houseInfoComponent4.Location = new System.Drawing.Point(0, 1588);
            this.houseInfoComponent4.MoneyLabel = "Số tiền";
            this.houseInfoComponent4.Name = "houseInfoComponent4";
            this.houseInfoComponent4.PictureBox = null;
            this.houseInfoComponent4.Size = new System.Drawing.Size(2120, 494);
            this.houseInfoComponent4.TabIndex = 5;
            // 
            // houseInfoComponent3
            // 
            this.houseInfoComponent3.AddressLabel = "Địa chỉ";
            this.houseInfoComponent3.AreaLabel = "Mét vuông";
            this.houseInfoComponent3.DescLabel = "Miêu tả";
            this.houseInfoComponent3.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent3.HomeLink = "Tên nhà";
            this.houseInfoComponent3.Location = new System.Drawing.Point(0, 1094);
            this.houseInfoComponent3.MoneyLabel = "Số tiền";
            this.houseInfoComponent3.Name = "houseInfoComponent3";
            this.houseInfoComponent3.PictureBox = null;
            this.houseInfoComponent3.Size = new System.Drawing.Size(2120, 494);
            this.houseInfoComponent3.TabIndex = 4;
            // 
            // houseInfoComponent2
            // 
            this.houseInfoComponent2.AddressLabel = "Địa chỉ";
            this.houseInfoComponent2.AreaLabel = "Mét vuông";
            this.houseInfoComponent2.DescLabel = "Miêu tả";
            this.houseInfoComponent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent2.HomeLink = "Tên nhà";
            this.houseInfoComponent2.Location = new System.Drawing.Point(0, 600);
            this.houseInfoComponent2.MoneyLabel = "Số tiền";
            this.houseInfoComponent2.Name = "houseInfoComponent2";
            this.houseInfoComponent2.PictureBox = null;
            this.houseInfoComponent2.Size = new System.Drawing.Size(2120, 494);
            this.houseInfoComponent2.TabIndex = 3;
            // 
            // houseInfoComponent1
            // 
            this.houseInfoComponent1.AddressLabel = "Địa chỉ";
            this.houseInfoComponent1.AreaLabel = "Mét vuông";
            this.houseInfoComponent1.DescLabel = "Miêu tả";
            this.houseInfoComponent1.Dock = System.Windows.Forms.DockStyle.Top;
            this.houseInfoComponent1.HomeLink = "Tên nhà";
            this.houseInfoComponent1.Location = new System.Drawing.Point(0, 106);
            this.houseInfoComponent1.MoneyLabel = "Số tiền";
            this.houseInfoComponent1.Name = "houseInfoComponent1";
            this.houseInfoComponent1.PictureBox = null;
            this.houseInfoComponent1.Size = new System.Drawing.Size(2120, 494);
            this.houseInfoComponent1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customComboBox_phuong);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.truongCbb);
            this.panel3.Controls.Add(this.dienTichCbb);
            this.panel3.Controls.Add(this.giaCbb);
            this.panel3.Controls.Add(this.quanCbb);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2120, 106);
            this.panel3.TabIndex = 0;
            // 
            // customComboBox_phuong
            // 
            this.customComboBox_phuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.customComboBox_phuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customComboBox_phuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox_phuong.BorderColor = System.Drawing.Color.Green;
            this.customComboBox_phuong.BorderSize = 3;
            this.customComboBox_phuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox_phuong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customComboBox_phuong.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox_phuong.IconColor = System.Drawing.Color.Green;
            this.customComboBox_phuong.Items.AddRange(new object[] {
            "Da nang",
            "Ha noi"});
            this.customComboBox_phuong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox_phuong.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox_phuong.Location = new System.Drawing.Point(397, 28);
            this.customComboBox_phuong.MinimumSize = new System.Drawing.Size(300, 52);
            this.customComboBox_phuong.Name = "customComboBox_phuong";
            this.customComboBox_phuong.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.customComboBox_phuong.Size = new System.Drawing.Size(348, 52);
            this.customComboBox_phuong.TabIndex = 9;
            this.customComboBox_phuong.Texts = "Phường";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchBtn.BackColor = System.Drawing.Color.Green;
            this.searchBtn.BackgroundColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 20;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(1888, 28);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(231, 52);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // truongCbb
            // 
            this.truongCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.truongCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.truongCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.truongCbb.BorderColor = System.Drawing.Color.Green;
            this.truongCbb.BorderSize = 3;
            this.truongCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.truongCbb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truongCbb.ForeColor = System.Drawing.Color.DimGray;
            this.truongCbb.IconColor = System.Drawing.Color.Green;
            this.truongCbb.Items.AddRange(new object[] {
            "DHBK Da Nang",
            "DHBK Ha Noi"});
            this.truongCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.truongCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.truongCbb.Location = new System.Drawing.Point(767, 28);
            this.truongCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.truongCbb.Name = "truongCbb";
            this.truongCbb.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.truongCbb.Size = new System.Drawing.Size(348, 52);
            this.truongCbb.TabIndex = 3;
            this.truongCbb.Texts = "Trường";
            // 
            // dienTichCbb
            // 
            this.dienTichCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dienTichCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dienTichCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dienTichCbb.BorderColor = System.Drawing.Color.Green;
            this.dienTichCbb.BorderSize = 3;
            this.dienTichCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dienTichCbb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienTichCbb.ForeColor = System.Drawing.Color.DimGray;
            this.dienTichCbb.IconColor = System.Drawing.Color.Green;
            this.dienTichCbb.Items.AddRange(new object[] {
            "100m^2",
            "200m^2"});
            this.dienTichCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.dienTichCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.dienTichCbb.Location = new System.Drawing.Point(1510, 28);
            this.dienTichCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.dienTichCbb.Name = "dienTichCbb";
            this.dienTichCbb.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.dienTichCbb.Size = new System.Drawing.Size(348, 52);
            this.dienTichCbb.TabIndex = 2;
            this.dienTichCbb.Texts = "Diện tích";
            // 
            // giaCbb
            // 
            this.giaCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.giaCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.giaCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.giaCbb.BorderColor = System.Drawing.Color.Green;
            this.giaCbb.BorderSize = 3;
            this.giaCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.giaCbb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaCbb.ForeColor = System.Drawing.Color.DimGray;
            this.giaCbb.IconColor = System.Drawing.Color.Green;
            this.giaCbb.Items.AddRange(new object[] {
            "10$",
            "20$"});
            this.giaCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.giaCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.giaCbb.Location = new System.Drawing.Point(1139, 28);
            this.giaCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.giaCbb.Name = "giaCbb";
            this.giaCbb.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.giaCbb.Size = new System.Drawing.Size(348, 52);
            this.giaCbb.TabIndex = 1;
            this.giaCbb.Texts = "Giá tiền";
            // 
            // quanCbb
            // 
            this.quanCbb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.quanCbb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.quanCbb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quanCbb.BorderColor = System.Drawing.Color.Green;
            this.quanCbb.BorderSize = 3;
            this.quanCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.quanCbb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanCbb.ForeColor = System.Drawing.Color.DimGray;
            this.quanCbb.IconColor = System.Drawing.Color.Green;
            this.quanCbb.Items.AddRange(new object[] {
            "Da nang",
            "Ha noi"});
            this.quanCbb.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.quanCbb.ListTextColor = System.Drawing.Color.DimGray;
            this.quanCbb.Location = new System.Drawing.Point(29, 28);
            this.quanCbb.MinimumSize = new System.Drawing.Size(300, 52);
            this.quanCbb.Name = "quanCbb";
            this.quanCbb.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.quanCbb.Size = new System.Drawing.Size(348, 52);
            this.quanCbb.TabIndex = 0;
            this.quanCbb.Texts = "Quận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(702, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duyệt theo diện tích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(142, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duyệt theo trường đại học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(702, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Duyệt theo giá tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Duyệt theo thành phố";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2154, 933);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1546, 966);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomComponents.CustomButton nextPageBtn;
        private CustomComponents.CustomButton prevPageBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CustomComponents.CustomComboBox quanCbb;
        private CustomComponents.CustomComboBox truongCbb;
        private CustomComponents.CustomComboBox dienTichCbb;
        private CustomComponents.CustomComboBox giaCbb;
        private CustomComponents.CustomButton searchBtn;
        private CustomComponents.CustomComboBox customComboBox_phuong;
        private CustomComponents.HouseInfoComponent houseInfoComponent5;
        private CustomComponents.HouseInfoComponent houseInfoComponent4;
        private CustomComponents.HouseInfoComponent houseInfoComponent3;
        private CustomComponents.HouseInfoComponent houseInfoComponent2;
        private CustomComponents.HouseInfoComponent houseInfoComponent1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}