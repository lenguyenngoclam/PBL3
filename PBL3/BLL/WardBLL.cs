using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class WardBLL
    {
        //Phương thức dùng để lấy tất cả phường có trong db
        public static List<Ward> GetAllWards()
        {
            using(var context = new MyData())
            {
                return context.Wards.ToList();
            }
        }
        public static int GetWardIDByName(string wardName)
        {
            using (var context = new MyData())
            {
                return context.Wards.Where(ward => ward.WardName == wardName).FirstOrDefault().WardID;
            }
        }
        public static string GetFullAddressFormat(int wardID)
        {
            using (var context = new MyData())
            {
                var ward = context.Wards.Where(w => w.WardID == wardID).FirstOrDefault();
                if (ward != null)
                {
                    string districtName = DistrictBLL.GetDistrictNameByID(ward.WardID);
                    return $"Phường : {ward.WardName}\nĐường : {districtName}";
                }
                else
                    return "";
            }
        }
    }
}
