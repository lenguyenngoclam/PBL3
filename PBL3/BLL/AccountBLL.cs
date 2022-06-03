using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class AccountBLL
    {
        //Phương thức được sử dụng để kiểm tra đăng nhập. Nếu thông tin đăng nhập không đúng
        //thì trả về rỗng
        public static string CheckRole(string username, string password)
        {
            using(var context = new MyData())
            {
                var acc = context.Accounts
                    .Where(account => account.UserName == username && account.Password == password)
                    .FirstOrDefault<Account>();
                if (acc != null)
                    return acc.Role.RoleName;
                else
                    return "";
            }
        }

        public static int GetAccountID(string username, string password)
        {
            using(var context = new MyData())
            {
                var account = context.Accounts
                    .Where(acc => acc.UserName == username && acc.Password == password)
                    .FirstOrDefault();
                if (account != null)
                    return account.AccountID;
                else
                    return -1;
            }
        }

        public static bool CheckExistingAccount(string username, string password)
        {
            if (GetAccountID(username, password) != -1)
                return true;
            return false;
        }

        public static void AddAccount(string username, string password, int roleID)
        {
            Account newAccount = new Account()
            {
                UserName = username,
                Password = password,
                RoleID = roleID,
                CreatedAt = DateTime.Now,
                ModifiedAt = null
            };
            using (var context = new MyData())
            {
                context.Accounts.Add(newAccount);
                context.SaveChanges();
            }

        }
    }
}
