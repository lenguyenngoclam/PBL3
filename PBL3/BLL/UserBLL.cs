using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class UserBLL
    {
        public static int GetUserIDByAccountID(int accountId)
        {
            using(var context = new MyData())
            {
                return context.Users.Where(user => user.AccountID == accountId)
                            .FirstOrDefault().UserID;
            }
        }
        public static void AddUser(int accountID, string name, string phone, string email, int addressID)
        {
            User newUser = new User()
            {
                FullName = name,
                Phone = phone,
                Email = email,
                AccountID = accountID,
                AddressID = addressID
            };
            using(var context = new MyData())
            {
                context.Users.Add(newUser);
                context.SaveChanges();
            }
        }
        
        public static User GetUserByID(int? userID)
        {
            if (userID == null)
                return null;
            using (var context = new MyData())
            {
                return context.Users.Where(u => u.UserID == userID).FirstOrDefault();
            }
        }
        public static int GetAccountIDByUserID(int userID)
        {
            using (var context = new MyData())
            {
                return context.Users.Where(user => user.UserID == userID)
                            .FirstOrDefault().AccountID;
            }
        }
        public static string GetContactInformation(int userID)
        {
            using (var context = new MyData())
            {
                return context.Users.Where(user => user.UserID == userID)
                            .FirstOrDefault().Phone;
            }
        }
        public static string GetNameInformation(int userID)
        {
            using (var context = new MyData())
            {
                return context.Users.Where(user => user.UserID == userID)
                            .FirstOrDefault().FullName;
            }
        }
    }
}
