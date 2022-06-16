using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3.DTO;

namespace PBL3.BLL
{
    public class AddressBLL
    {
        public static int AddAddress(string detailAddr, int wardID)
        {
            Address address = new Address()
            {
                DetailAddress = detailAddr,
                WardID = wardID
            };
            using (var context = new MyData())
            {
                context.Addresses.Add(address);
                context.SaveChanges();

                return address.AddressID;
            }
        }
        public static void DeleteAddress(int? addressID)
        {
            using (var context = new MyData())
            {
                Address address = context.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
                context.Addresses.Remove(address);
                context.SaveChanges();
            }
        }

        public static void UpdateAddress(string detailAddress, int addressID)
        {
            using (var context = new MyData())
            {
                Address address = context.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault();
                address.DetailAddress = detailAddress;
                context.SaveChanges();
            }
        }
        public static string GetFullAddressFormat(int? addressID)
        {
            if (addressID == null)
                return "";
            using (var context = new MyData())
            {
                var address = context.Addresses.Where(addr => addr.AddressID == addressID).FirstOrDefault();
                if (address != null)
                {
                    return $"Địa chỉ cụ thể : {address.DetailAddress} \n" +
                        $"{WardBLL.GetFullAddressFormat(address.WardID)}";
                }
                else
                    return "";
            }
        }

        public static string GetDetailAddress(int? addressID)
        {
            using (var context = new MyData())
            {
                return context.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault().DetailAddress;
            }
        }
        public static int GetWardIDByAddressID(int? addressID)
        {
            using (var context = new MyData())
            {
                return context.Addresses.Where(a => a.AddressID == addressID).FirstOrDefault().WardID;
            }
        }

    }
}
