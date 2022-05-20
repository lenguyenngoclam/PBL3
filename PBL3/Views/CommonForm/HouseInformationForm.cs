using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CommonForm
{
    public partial class HouseInformationForm : Form
    {
        private int index = 0;
        public HouseInformationForm()
        {
            InitializeComponent();
        }

        private void prevImgBtn_Click(object sender, EventArgs e)
        {
            index -= 1;
            if (index < 0)
                index = imageList1.Images.Count - 1;
            pictureBox1.Image = imageList1.Images[index];
        }

        private void nextImgBtn_Click(object sender, EventArgs e)
        {
            index += 1;
            if (index >= imageList1.Images.Count)
                index = 0;
            pictureBox1.Image = imageList1.Images[index];
        }
    }
}
