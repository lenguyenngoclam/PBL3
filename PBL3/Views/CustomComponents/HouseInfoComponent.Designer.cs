
namespace PBL3.Views.CustomComponents
{
    partial class HouseInfoComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tienLabel = new System.Windows.Forms.Label();
            this.dienTichLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.mieuTaLabel = new System.Windows.Forms.Label();
            this.tenNhaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tienLabel
            // 
            this.tienLabel.AutoSize = true;
            this.tienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tienLabel.Location = new System.Drawing.Point(662, 410);
            this.tienLabel.Name = "tienLabel";
            this.tienLabel.Size = new System.Drawing.Size(98, 31);
            this.tienLabel.TabIndex = 2;
            this.tienLabel.Text = "Số tiền";
            // 
            // dienTichLabel
            // 
            this.dienTichLabel.AutoSize = true;
            this.dienTichLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dienTichLabel.Location = new System.Drawing.Point(663, 151);
            this.dienTichLabel.Name = "dienTichLabel";
            this.dienTichLabel.Size = new System.Drawing.Size(140, 31);
            this.dienTichLabel.TabIndex = 3;
            this.dienTichLabel.Text = "Mét vuông";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.Location = new System.Drawing.Point(663, 240);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(115, 37);
            this.diaChiLabel.TabIndex = 4;
            this.diaChiLabel.Text = "Địa chỉ";
            // 
            // mieuTaLabel
            // 
            this.mieuTaLabel.AutoSize = true;
            this.mieuTaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mieuTaLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.mieuTaLabel.Location = new System.Drawing.Point(663, 319);
            this.mieuTaLabel.Name = "mieuTaLabel";
            this.mieuTaLabel.Size = new System.Drawing.Size(102, 31);
            this.mieuTaLabel.TabIndex = 5;
            this.mieuTaLabel.Text = "Miêu tả";
            // 
            // tenNhaLinkLabel
            // 
            this.tenNhaLinkLabel.AutoSize = true;
            this.tenNhaLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNhaLinkLabel.ForeColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.LinkColor = System.Drawing.Color.Red;
            this.tenNhaLinkLabel.Location = new System.Drawing.Point(657, 44);
            this.tenNhaLinkLabel.Name = "tenNhaLinkLabel";
            this.tenNhaLinkLabel.Size = new System.Drawing.Size(224, 63);
            this.tenNhaLinkLabel.TabIndex = 6;
            this.tenNhaLinkLabel.TabStop = true;
            this.tenNhaLinkLabel.Text = "Tên nhà";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PBL3.Properties.Resources.ImageNotFound;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 323);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HouseInfoComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tenNhaLinkLabel);
            this.Controls.Add(this.mieuTaLabel);
            this.Controls.Add(this.diaChiLabel);
            this.Controls.Add(this.dienTichLabel);
            this.Controls.Add(this.tienLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HouseInfoComponent";
            this.Size = new System.Drawing.Size(1330, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tienLabel;
        private System.Windows.Forms.Label dienTichLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.Label mieuTaLabel;
        private System.Windows.Forms.LinkLabel tenNhaLinkLabel;
    }
}
