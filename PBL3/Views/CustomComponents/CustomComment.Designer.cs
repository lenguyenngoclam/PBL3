
namespace PBL3.Views.CustomComponents
{
    partial class CustomComment
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.cmtLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameLabel.Location = new System.Drawing.Point(0, 0);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.usernameLabel.Size = new System.Drawing.Size(187, 113);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Tên người dùng";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmtLabel
            // 
            this.cmtLabel.BackColor = System.Drawing.Color.White;
            this.cmtLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmtLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtLabel.Location = new System.Drawing.Point(187, 0);
            this.cmtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cmtLabel.Name = "cmtLabel";
            this.cmtLabel.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.cmtLabel.Size = new System.Drawing.Size(472, 113);
            this.cmtLabel.TabIndex = 1;
            this.cmtLabel.Text = "NỘI DUNG COMMENT";
            this.cmtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmtLabel);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomComment";
            this.Size = new System.Drawing.Size(659, 113);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label cmtLabel;
    }
}
