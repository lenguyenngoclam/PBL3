using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.DTO.ViewDTO;

namespace PBL3.BLL
{
    public class PostBLL
    {
        public static int GetToTalNumberOfPosts()
        {
            using(var context = new MyData())
            {
                return context.Posts.ToList().Count;
            }
        }

        public static List<PostViewDTO> GetPosts(int skipNum, int postNum)
        {
            List<PostViewDTO> ls = new List<PostViewDTO>();
            using (var context = new MyData())
            {
                context.Posts.OrderBy(post => post.PostID).Skip(skipNum).Take(postNum)
                    .ToList().ForEach(post => ls.Add(new PostViewDTO()
                    {
                        PostID = post.PostID,
                        Title = post.Title,
                        Description = post.Description,
                        Area = post.Square,
                        Price = post.Price,
                        Address = AddressBLL.GetFullAddressFormat(post.AddressID),
                        UserID = post.UserID,
                        ImagePaths = ImageBLL.GetImagePaths(post.PostID)
                    }));
                return ls;
            }
        }

        public static PostViewDTO GetPostByID(int postID)
        {
           using(var context = new MyData())
            {
                var post = context.Posts.Where(p => p.PostID == postID).FirstOrDefault();
                return new PostViewDTO()
                {
                    PostID = post.PostID,
                    Title = post.Title,
                    Description = post.Description,
                    Area = post.Square,
                    Price = post.Price,
                    Address = AddressBLL.GetFullAddressFormat(post.AddressID),
                    UserID = post.UserID,
                    ImagePaths = ImageBLL.GetImagePaths(post.PostID)
                };
            }
        }

        public static int AddPost(int userID, int addressID, string title, string description, int price, double area)
        {
            using (var context = new MyData())
            {
                Post post = new Post()
                {
                    UserID = userID,
                    AddressID = addressID,
                    Title = title,
                    Description = description,
                    Price = price,
                    Square = area,
                    BeingPosted = false,
                    BeingRented = false,
                    CreatedAt = DateTime.Now
                };
                context.Posts.Add(post);
                context.SaveChanges();
                return post.PostID;
            }
        }
        public static void UpdatePost(int postID, int newAddressID, string title, string desc, int price, double area)
        {
            using (var context = new MyData())
            {
                Post post = context.Posts.Where(p => p.PostID == postID).FirstOrDefault();
                post.AddressID = newAddressID;
                post.Title = title;
                post.Description = desc;
                post.Price = price;
                post.Square = area;
                context.SaveChanges();
            }
        }
        public static int? GetAddressIDByPostID(int postID)
        {
            using (var context = new MyData())
            {
                return context.Posts.Where(p => p.PostID == postID).FirstOrDefault().AddressID;      
            }
        }
    }
}
