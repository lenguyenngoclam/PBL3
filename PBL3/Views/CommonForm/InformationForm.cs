using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.Views.CommonForm
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            InitializeInformation();
        }

        private void InitializeInformation()
        {
            User user = UserBLL.GetUserByID(LoginInfo.UserID);
            nameField.Text = user.FullName;
            addressField.Text = AddressBLL.GetFullAddressFormat(user.UserID);
            phoneField.Text = user.Phone;
        }
        private void scaleFont(Label lab)
        {
            System.Drawing.Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
            Graphics graphics = Graphics.FromImage(fakeImage);

            SizeF extent = graphics.MeasureString(lab.Text, lab.Font);

            float hRatio = lab.Height / extent.Height;
            float wRatio = lab.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = lab.Font.Size * ratio;

            lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
        }
    }
}
