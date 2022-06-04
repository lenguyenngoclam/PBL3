using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class RatingBLL
    {
        public static void AddRating(int userID, int postID, int starNums)
        {
            using (var context = new MyData())
            {
                Rating rating = new Rating()
                {
                    UserID = userID,
                    PostID = postID,
                    Star = starNums,
                    CreatedAt = DateTime.Now
                };
                context.Ratings.Add(rating);
                context.SaveChanges();
            }
        }

        public static bool CheckRating(int userID, int postID)
        {
            using (var context = new MyData())
            {
                var rating = context.Ratings
                    .Where(r => r.UserID == userID && r.PostID == postID).FirstOrDefault();
                if (rating == null)
                    return false;
                else
                    return true;
            }
        }

        public static int GetStars(int userID, int postID)
        {
            using (var context = new MyData())
            {
                return context.Ratings.Where(c => c.UserID == userID && c.PostID == postID).FirstOrDefault().Star;
            }
        }
    }
}
