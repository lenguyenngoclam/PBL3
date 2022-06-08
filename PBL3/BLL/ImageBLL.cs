using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;
using System.IO;
using System.Windows.Forms;

namespace PBL3.BLL
{
    public class ImageBLL
    {
        //Lấy chuỗi các đường dẫn ảnh từ postID
        public static List<string> GetImagePaths(int postID)
        {
            using (var context = new MyData())
            {
                List<string> ls = new List<string>();
                //Lấy ảnh dựa trên post id
                var images = context.Images.Where(image => image.PostID == postID);

                images.ToList().ForEach(image => ls.Add(image.ImagePath));
                return ls.Take(3).ToList();
            }
        }

        //Lấy đường dẫn của thư mục lưu trữ ảnh của người dùng có UserID
        public static string GetImageStoragePathsOfPost(int? postID)
        {
            if (postID == null)
                return "";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            string appPath = Path.GetFullPath(Path.Combine(path, @"..\..\")) 
                + @"Resources\Post" + postID.ToString();
            return appPath;
        }

        public static void AddImage(string imagePath, int postID)
        {
            using (var context = new MyData())
            {
                Image image = new Image()
                {
                    ImagePath = imagePath,
                    PostID = postID
                };
                context.Images.Add(image);
                context.SaveChanges();
            }
        }
    }
}
