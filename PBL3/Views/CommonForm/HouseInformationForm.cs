﻿using System;
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
using PBL3.DTO;
using PBL3.BLL;
using PBL3.DTO.ViewDTO;
using System.IO;

namespace PBL3.Views.CommonForm
{
    public partial class HouseInformationForm : Form
    {
        //Image index
        private int index = 0;
        //Star for rating
        private int starNum = 0;

        //This part is for comment section
        private int commentNum;
        private int totalCommentNum;
        private int currentCommentPage = 0;
        private int totalPage;
        private int skipNum = 4;

        //Store post information in here
        private int PostID;
        public HouseInformationForm(int postID)
        {
            PostID = postID;
            InitializeComponent();
            InitializeFormInfomation();
            InitializeImageList();
            if (RatingBLL.CheckRating(LoginInfo.UserID, PostID))
            {
                DisableRating();
                InitializeRating();
            }
            LoadComment();
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
            Display1Star();
            ConfirmRating();
        }

        private void star2_Click(object sender, EventArgs e)
        {
            starNum = 2;
            Display2Star();
            ConfirmRating();
        }

        private void star3_Click(object sender, EventArgs e)
        {
            starNum = 3;
            Display3Star();
            ConfirmRating();
        }

        private void star4_Click(object sender, EventArgs e)
        {
            starNum = 4;
            Display4Star();
            ConfirmRating();
        }

        private void star5_Click(object sender, EventArgs e)
        {
            starNum = 5;
            Display5Star();
            ConfirmRating();
        }

        private void Display5Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.yellow_star;
        }
        private void Display4Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.yellow_star;
            star5.Image = Resources.white_star;
        }
        private void Display3Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.yellow_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }
        private void Display2Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.yellow_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }
        private void Display1Star()
        {
            star1.Image = Resources.yellow_star;
            star2.Image = Resources.white_star;
            star3.Image = Resources.white_star;
            star4.Image = Resources.white_star;
            star5.Image = Resources.white_star;
        }

        private void InitializeRating()
        {
            int stars = RatingBLL.GetStars(LoginInfo.UserID, PostID);
            switch (stars)
            {
                case 1:
                    Display1Star();
                    break;
                case 2:
                    Display2Star();
                    break;
                case 3:
                    Display3Star();
                    break;
                case 4:
                    Display4Star();
                    break;
                case 5:
                    Display5Star();
                    break;
            }
        }
        private void InitializeImageList()
        {
           
            try
            {
                PostViewDTO post = PostBLL.GetPostByID(PostID);
                string imagePath = ImageBLL.GetImageStoragePathsOfPost(PostID);
                post.ImagePaths
                .ForEach(image =>
                {
                    System.Drawing.Image image1;
                    using (Stream stream = File.OpenRead(imagePath + image))
                    {
                        image1 = System.Drawing.Image.FromStream(stream);
                    }
                    imageList1.Images.Add(image1);
                });
            }
            catch (Exception exp)
            {
                MessageBox.Show("Unable to open file " + exp.Message);
            }
            if (imageList1.Images.Count > 0)
                pictureBox1.Image = imageList1.Images[0];
            else
                pictureBox1.Image = Resources.ImageNotFound;
        }

        private void InitializeFormInfomation()
        {
            PostViewDTO post = PostBLL.GetPostByID(PostID);
            string contact = UserBLL.GetContactInformation(LoginInfo.UserID);
            string name = UserBLL.GetNameInformation(LoginInfo.UserID);
            addressField.Text = post.Address;
            areaField.Text = post.Area.ToString();
            titleField.Text = post.Title;
            contactField.Text = contact;
            priceField.Text = post.Price.ToString();
            nameField.Text = name;
            userPhoneField.Text = contact;
        }

        private void DisableRating()
        {
            star1.Enabled = false;
            star2.Enabled = false;
            star3.Enabled = false;
            star4.Enabled = false;
            star5.Enabled = false;
        }

        private void ConfirmRating()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn rating ? Sau khi rating không thể thử lại",
                "Xác nhận",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            else if(result == DialogResult.Yes)
            {
                RatingBLL.AddRating(LoginInfo.UserID, PostID, starNum);
                MessageBox.Show("Rating thành công!");
                DisableRating();
            }
        }

        private void LoadComment()
        {
            DisplayAllComment();
            totalCommentNum = CommentBLL.GetNumberOfComments(PostID);
            totalPage = (int)Math.Ceiling(totalCommentNum / Convert.ToDouble(skipNum));
            commentNum = (totalCommentNum - 4 * currentCommentPage < 4) ? totalCommentNum - 4 * currentCommentPage : 4;

            HideComment(commentNum);
            List<CommentViewDTO> comments = CommentBLL.GetComments(PostID, currentCommentPage * skipNum, commentNum);
            if (customComment1.Visible)
            {
                customComment1.Comment = comments[0].Content;
                customComment1.Username = UserBLL.GetNameInformation(comments[0].UserID);
            }
            if (customComment2.Visible)
            {
                customComment2.Comment = comments[1].Content;
                customComment2.Username = UserBLL.GetNameInformation(comments[1].UserID);
            }
            if (customComment3.Visible)
            {
                customComment3.Comment = comments[2].Content;
                customComment3.Username = UserBLL.GetNameInformation(comments[2].UserID);
            }
            if (customComment4.Visible)
            {
                customComment4.Comment = comments[3].Content;
                customComment4.Username = UserBLL.GetNameInformation(comments[3].UserID);
            }
        }

        private void DisplayAllComment()
        {
            this.Visible = true;
            panel3.Visible = true;
            customComment1.Visible = true;
            customComment2.Visible = true;
            customComment3.Visible = true;
            customComment4.Visible = true;
        }
        
        private void HideComment(int commentNum)
        {
            switch (commentNum)
            {
                case 3:
                    customComment4.Visible = false;
                    break;
                case 2:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    break;
                case 1:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    break;
                case 0:
                    customComment4.Visible = false;
                    customComment3.Visible = false;
                    customComment2.Visible = false;
                    customComment1.Visible = false;
                    break;
            }
        }

        private void uploadCmtBtn_Click(object sender, EventArgs e)
        {
            if (cmtTextbox.Text != "")
            {
                CommentBLL.AddComment(LoginInfo.UserID, PostID, cmtTextbox.Text);
                cmtTextbox.Text = "";
            }
            else
                MessageBox.Show("Vui lòng nhập comment");
            LoadComment();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage - 1;
            if (currentCommentPage < 0)
                currentCommentPage = totalPage - 1;
            LoadComment();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentCommentPage = currentCommentPage + 1;
            if (currentCommentPage == totalPage)
                currentCommentPage = 0;
            LoadComment();
        }
    }
}
