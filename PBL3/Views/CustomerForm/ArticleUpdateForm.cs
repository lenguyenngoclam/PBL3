using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.Views.CustomerForm
{
    public partial class ArticleUpdateForm : Form
    {
        private Dictionary<string, string> mapImgFolderToResourcesFolderHashSet;
        private string appPath = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                    @"..\..\")) + @"Resources\Images\";
        public ArticleUpdateForm()
        {
            InitializeComponent();
            mapImgFolderToResourcesFolderHashSet = new Dictionary<string, string>();
        }

        private void changeImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Chọn ba bức hình";
            opFile.Multiselect = true;
            opFile.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";

            if (Directory.Exists(appPath) == false)
            {
                createDirectoryWithFullAccess(appPath);
            }

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (opFile.FileNames.Length != 3)
                    {
                        MessageBox.Show("Bạn phải chọn 3 bức hình");
                        opFile.Dispose();
                        return;
                    }
                    IEnumerable<string> imagesIterator = opFile.FileNames.Take(3);
                    string[] images = imagesIterator.ToArray();
                    pictureBox1.Image = Image.FromFile(images[0]);
                    pictureBox2.Image = Image.FromFile(images[1]);
                    pictureBox3.Image = Image.FromFile(images[2]);
                    for (int i = 0; i < 3; i++)
                    {
                        mapImgFolderToResourcesFolderHashSet.Add(images[i], appPath + opFile.SafeFileNames[i]);
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

        private void deleteImageFromFolder(string appPath)
        {
            DirectoryInfo d = new DirectoryInfo(appPath); 

            FileInfo[] Files = d.GetFiles(); 

            foreach (FileInfo file in Files)
            {
                File.Delete(appPath + file.Name);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            deleteImageFromFolder(appPath);
            foreach (KeyValuePair<string, string> entry in mapImgFolderToResourcesFolderHashSet)
            { 
                File.Copy(entry.Key, entry.Value);
            }
            this.Close();
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createDirectoryWithFullAccess(string appPath)
        {
            Directory.CreateDirectory(appPath);
            DirectoryInfo directory = new DirectoryInfo(appPath);
            DirectorySecurity security = directory.GetAccessControl();

            security.AddAccessRule(new FileSystemAccessRule("User",
                                    FileSystemRights.Modify,
                                    AccessControlType.Deny));

            directory.SetAccessControl(security);
        }
    }
}
