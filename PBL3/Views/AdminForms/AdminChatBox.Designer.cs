
namespace PBL3.Views.AdminForms
{
    partial class AdminChatBox
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.messageTextbox = new PBL3.Views.CustomComponents.CustomTextBox();
            this.sendBtn = new PBL3.Views.CustomComponents.CustomButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(925, 599);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // messageTextbox
            // 
            this.messageTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextbox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.messageTextbox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.messageTextbox.BorderRadius = 0;
            this.messageTextbox.BorderSize = 2;
            this.messageTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextbox.ForeColor = System.Drawing.Color.DimGray;
            this.messageTextbox.Location = new System.Drawing.Point(41, 670);
            this.messageTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.messageTextbox.Multiline = false;
            this.messageTextbox.Name = "messageTextbox";
            this.messageTextbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.messageTextbox.PasswordChar = false;
            this.messageTextbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.messageTextbox.PlaceholderText = "";
            this.messageTextbox.Size = new System.Drawing.Size(736, 45);
            this.messageTextbox.TabIndex = 1;
            this.messageTextbox.Texts = "";
            this.messageTextbox.UnderlinedStyle = false;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendBtn.BackColor = System.Drawing.Color.Green;
            this.sendBtn.BackgroundColor = System.Drawing.Color.Green;
            this.sendBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sendBtn.BorderRadius = 10;
            this.sendBtn.BorderSize = 0;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(813, 670);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(153, 45);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.TextColor = System.Drawing.Color.White;
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // AdminChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3.Properties.Resources.loginBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 758);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.messageTextbox);
            this.Controls.Add(this.listView1);
            this.Name = "AdminChatBox";
            this.Text = "Chatbox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminChatBox_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private CustomComponents.CustomTextBox messageTextbox;
        private CustomComponents.CustomButton sendBtn;
    }
}