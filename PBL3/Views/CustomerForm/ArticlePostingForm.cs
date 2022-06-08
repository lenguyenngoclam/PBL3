using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.Views.CustomerForm
{
    public partial class ArticlePostingForm : Form
    {
        private List<string> ImagePathList;
        private List<string> imageFileName;
        public ArticlePostingForm()
        {
            InitializeComponent();
            ImagePathList = new List<string>();
            imageFileName = new List<string>();
            DistrictBLL.GetAllDistricts().ForEach(district => quanComboBox.Items.Add(district.DistrictName));
            quanComboBox.SelectedIndex = 0;
        }

        private void uploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Chọn ba bức hình";
            opFile.Multiselect = true;
            opFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                                                                                  
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if(opFile.FileNames.Length != 3)
                    {
                        MessageBox.Show("Bạn phải chọn 3 bức hình");
                        opFile.Dispose();
                        return;
                    } else if(opFile.FileNames.Distinct().Count() != opFile.FileNames.Length)
                    {
                        MessageBox.Show("Tên File phải khác nhau");
                        opFile.Dispose();
                    }
                    IEnumerable<string> imagesIterator = opFile.FileNames.Take(3);
                    string[] images = imagesIterator.ToArray();
                    pictureBox1.Image = System.Drawing.Image.FromFile(images[0]);
                    pictureBox2.Image = System.Drawing.Image.FromFile(images[1]);
                    pictureBox3.Image = System.Drawing.Image.FromFile(images[2]);
                    for(int i = 0; i < 3; i++)
                    {
                        ImagePathList.Add(images[i]);
                        imageFileName.Add(opFile.SafeFileNames[i]);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void uploadArticleBtn_Click(object sender, EventArgs e)
        {
            if(ImagePathList.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh");
                return;
            }
            int addressID = AddressBLL.AddAddress(soNhaTextBox.Texts, WardBLL.GetWardIDByName(phuongComboBox.SelectedItem.ToString()));
            int postID = PostBLL.AddPost(LoginInfo.UserID, addressID, titleTextbox.Texts, descTextbox.Texts, Convert.ToInt32(priceTextBox.Texts),
                                                                Convert.ToDouble(areaTextbox.Texts));
            string imagePathStorage = ImageBLL.GetImageStoragePathsOfPost(postID);
            if (!Directory.Exists(imagePathStorage))
                Directory.CreateDirectory(imagePathStorage);
            for(int i = 0; i < 3; i++)
            {
                File.Copy(ImagePathList[i], imagePathStorage + @"\" + imageFileName[i]);
                ImageBLL.AddImage(@"\" + imageFileName[i], postID);
            }
            this.Close();
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            phuongComboBox.Items.Clear();
            string districtName = quanComboBox.SelectedItem.ToString();
            WardBLL.GetWardByDistrictID(DistrictBLL.GetDistrictIDByName(districtName))
                .ForEach(w => phuongComboBox.Items.Add(w.WardName));
            phuongComboBox.SelectedIndex = 0;
        }
    }
}
