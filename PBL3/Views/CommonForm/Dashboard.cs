using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

namespace PBL3.Views.CommonForm
{
    public partial class Dashboard : Form
    {
        private int currentPage = 0;
        private int totalPage;
        private int numberOfPosts;
        private int skipNum = 5;
        private int postNum;
        public Dashboard()
        {
            InitializeComponent();
            numberOfPosts = PostBLL.GetToTalNumberOfPosts();
            postNum = (numberOfPosts - currentPage * 5 < 5) ? numberOfPosts - currentPage * 5 : 5; 
            totalPage = (int)Math.Ceiling(PostBLL.GetToTalNumberOfPosts() / Convert.ToDouble(skipNum));
            ShowPosts();
        }

        private void ShowPosts()
        {
            postNum = (numberOfPosts - currentPage * 5 < 5) ? numberOfPosts - currentPage * 5 : 5;
            DisplayHouseInformation();
            List<PostViewDTO> postView = PostBLL.GetPosts(currentPage * skipNum, postNum);

            //When number of post < 5
            DisablePostViewWhenNotFount(postNum);

            string imagePath;
            if (houseInfoComponent1.Visible)
            {
                houseInfoComponent1.DescLabel = "Miêu tả : " + postView[0].Description;
                houseInfoComponent1.AddressLabel = "Địa chỉ : " + postView[0].Address;
                houseInfoComponent1.HomeLink = postView[0].Title;
                houseInfoComponent1.MoneyLabel = "Số tiền : " +  postView[0].Price;
                houseInfoComponent1.AreaLabel = "Diện tích : " +  postView[0].Area;

                imagePath = ImageBLL.GetImageStoragePathsOfPost(postView[0].PostID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if(postView[0].ImagePaths.Count > 0)
                {
                    houseInfoComponent1.PictureBox = System.Drawing.Image.FromFile(imagePath + postView[0].ImagePaths[0]);
                }
            }
            if (houseInfoComponent2.Visible)
            {
                houseInfoComponent2.DescLabel = "Miêu tả : " + postView[1].Description;
                houseInfoComponent2.AddressLabel = "Địa chỉ : " + postView[1].Address;
                houseInfoComponent2.HomeLink = postView[1].Title;
                houseInfoComponent2.MoneyLabel = "Số tiền : " + postView[1].Price;
                houseInfoComponent2.AreaLabel = "Diện tích : " + postView[1].Area;

                imagePath = ImageBLL.GetImageStoragePathsOfPost(postView[1].PostID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[1].ImagePaths.Count > 0)
                {
                    houseInfoComponent2.PictureBox = System.Drawing.Image.FromFile(imagePath + postView[1].ImagePaths[0]);
                }
            }
            if (houseInfoComponent3.Visible)
            {
                houseInfoComponent3.DescLabel = "Miêu tả : " + postView[2].Description;
                houseInfoComponent3.AddressLabel = "Địa chỉ : " + postView[2].Address;
                houseInfoComponent3.HomeLink = postView[2].Title;
                houseInfoComponent3.MoneyLabel = "Số tiền : " + postView[2].Price;
                houseInfoComponent3.AreaLabel = "Diện tích : " + postView[2].Area;

                imagePath = ImageBLL.GetImageStoragePathsOfPost(postView[2].PostID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[2].ImagePaths.Count > 0)
                {
                    houseInfoComponent3.PictureBox = System.Drawing.Image.FromFile(imagePath + postView[2].ImagePaths[0]);
                }
            }
            if (houseInfoComponent4.Visible)
            {
                houseInfoComponent4.DescLabel = "Miêu tả : " + postView[3].Description;
                houseInfoComponent4.AddressLabel = "Địa chỉ : " + postView[3].Address;
                houseInfoComponent4.HomeLink = postView[3].Title;
                houseInfoComponent4.MoneyLabel = "Số tiền : " + postView[3].Price;
                houseInfoComponent4.AreaLabel = "Diện tích : " + postView[3].Area;

                imagePath = ImageBLL.GetImageStoragePathsOfPost(postView[3].PostID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[3].ImagePaths.Count > 0)
                {
                    houseInfoComponent4.PictureBox = System.Drawing.Image.FromFile(imagePath + postView[3].ImagePaths[0]);
                }
            }
            if (houseInfoComponent5.Visible)
            {
                houseInfoComponent5.DescLabel = "Miêu tả : " + postView[4].Description;
                houseInfoComponent5.AddressLabel = "Địa chỉ : " + postView[4].Address;
                houseInfoComponent5.HomeLink = postView[4].Title;
                houseInfoComponent5.MoneyLabel = "Số tiền : " + postView[4].Price;
                houseInfoComponent5.AreaLabel = "Diện tích : " + postView[4].Area;

                imagePath = ImageBLL.GetImageStoragePathsOfPost(postView[4].PostID);
                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);
                if (postView[4].ImagePaths.Count > 0)
                {
                    houseInfoComponent5.PictureBox = System.Drawing.Image.FromFile(imagePath + postView[4].ImagePaths[0]);
                }
            }
        }
        private void DisablePostViewWhenNotFount(int postNum)
        {
            switch (postNum)
            {
                case 4:
                    houseInfoComponent5.Visible = false;
                    break;
                case 3:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    break;
                case 2:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    houseInfoComponent3.Visible = false;
                    break;
                case 1:
                    houseInfoComponent5.Visible = false;
                    houseInfoComponent4.Visible = false;
                    houseInfoComponent3.Visible = false;
                    houseInfoComponent2.Visible = false;
                    break;
            }
        }
        private void DisplayHouseInformation()
        {
            this.Visible = true;
            panel2.Visible = true;
            houseInfoComponent1.Visible = true;
            houseInfoComponent2.Visible = true;
            houseInfoComponent3.Visible = true;
            houseInfoComponent4.Visible = true;
            houseInfoComponent5.Visible = true;
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = currentPage - 1;
            if (currentPage < 0)
                currentPage = totalPage - 1;
            ShowPosts();
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            currentPage = currentPage + 1;
            if (currentPage == totalPage)
                currentPage = 0;
            ShowPosts();
        }
    }
}
