using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using PBL3.Properties;

namespace PBL3.Views.CommonForm
{
    public partial class HouseInformationForm : Form
    {
        private int index = 0;
        private int starNum = 0;
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

        private void star1_Click(object sender, EventArgs e)
        {
            starNum = 1;
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.white_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            starNum = 2;
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            starNum = 3;
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            starNum = 4;
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.white_star;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            starNum = 5;
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.yellow_star;
        }
    }
}
