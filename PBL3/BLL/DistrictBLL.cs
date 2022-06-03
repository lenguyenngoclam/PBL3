using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
using PBL3.DAL;

namespace PBL3.BLL
{
    public class DistrictBLL
    {
        public static string GetDistrictNameByID(int districtID)
        {
            using (var context = new MyData())
            {
                return context.Districts.Where(d => d.DistrictID == districtID)
                    .FirstOrDefault().DistrictName;
            }
        }
    }
}
