using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;
namespace PBL3.DAL
{
    public class CreateDB :
       // CreateDatabaseIfNotExists<MyData>
    //DropCreateDatabaseIfModelChanges<MyData>
    DropCreateDatabaseAlways<MyData>
    {
        protected override void Seed(MyData context)
        {
            context.Roles.AddRange(new Role[]
            {
                new Role {RoleID = 1, RoleName = "Admin"},
                new Role {RoleID = 2, RoleName = "Host"},
                new Role {RoleID = 3, RoleName = "Renter"}
            });

            context.Accounts.AddRange(new Account[]
            {
                new Account {AccountID = 1, UserName = "Admin1", Password = "0000", RoleID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Account {AccountID = 2, UserName = "Host1", Password = "0000", RoleID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Account {AccountID = 3, UserName = "Renter1", Password = "0000", RoleID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
            });


            context.Districts.AddRange(new District[]
            {
                new District {DistrictID = 1, DistrictName = "Hải Châu", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 2, DistrictName = "Cẩm Lệ", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 3, DistrictName = "Thanh Khê", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 4, DistrictName = "Liên Chiểu", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 5, DistrictName = "Ngũ Hành Sơn", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 6, DistrictName = "Sơn Trà", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 7, DistrictName = "Hòa Vang", CreatedAt = DateTime.Now, ModifiedAt = null},
                new District {DistrictID = 8, DistrictName = "Trường Sa", CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Wards.AddRange(new Ward[]
            {
                //10 phường
                new Ward {WardID = 1, WardName = "Thanh Bình", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 2, WardName = "Khuê Trung", DistrictID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 3, WardName = "Vĩnh Trung", DistrictID = 3, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 4, WardName = "Hòa Khánh Bắc", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 5, WardName = "Mỹ An", DistrictID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 6, WardName = "Phước Mỹ", DistrictID = 6, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 7, WardName = "Hòa Bắc", DistrictID = 7, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 8, WardName = "Sinh Tồn", DistrictID = 8, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 9, WardName = "Phước Ninh", DistrictID = 1, CreatedAt = DateTime.Now, ModifiedAt = null},
                new Ward {WardID = 10, WardName = "Hòa Khánh Nam", DistrictID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Universities.AddRange(new University[]
            {
                new University {UniversityID = 1, UniversityName = "ĐH Bách Khoa Đà Nẵng", WardID = 4, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 2, UniversityName = "ĐH Kinh Tế Đà Nẵng", WardID = 5, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 3, UniversityName = "ĐH Sư Phạm Đà Nẵng", WardID = 10, CreatedAt = DateTime.Now, ModifiedAt = null},
                new University {UniversityID = 4, UniversityName = "ĐH Ngoại Ngữ Đà Nẵng", WardID = 2, CreatedAt = DateTime.Now, ModifiedAt = null},
            });
            context.Addresses.AddRange(new Address[]
            {
                new Address {AddressID = 1, WardID = 4, DetailAddress = "54 Nguyễn Lương Bằng"},
                new Address {AddressID = 2, WardID = 5, DetailAddress = "71 Ngũ Hành Sơn"},
                new Address {AddressID = 3, WardID = 10, DetailAddress = "459 Tôn Đức Thắng"},
            });

            context.Users.AddRange(new User[]
            {
                new User {UserID = 1, FullName = "CKVM", Email ="1@gmail.com", AddressID = 1, Phone = "123", AccountID = 1},
                new User {UserID = 2, FullName = "LNNL", Email ="2@gmail.com", AddressID = 2, Phone = "456", AccountID = 2},
                new User {UserID = 3, FullName = "VHB", Email ="3@gmail.com", AddressID = 3, Phone = "789", AccountID = 3},

            });



            context.Posts.AddRange(new Post[]
            {
                new Post {PostID = 1, UserID = 2, AddressID = 1, Title = "Cho thuê trọ tại BK ĐN", Description = "Trọ bao đẹp",
                            Price = 1300000, Square = 22.5f, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
                new Post {PostID = 2, UserID = 2, AddressID = 2, Title = "Cho thuê trọ tại ĐH KT ĐN", Description = "Trọ bao đẹp",
                            Price = 1000000, Square = 10.5f, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
                new Post {PostID = 3, UserID = 2, AddressID = 2, Title = "Cho thuê trọ tại ĐH NN DN", Description = "Trọ bao đẹp",
                            Price = 10320000, Square = 10.5f, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
                new Post {PostID = 4, UserID = 1, AddressID = 2, Title = "Cho thuê trọ tại ĐH VN-UK", Description = "Trọ bao đẹp",
                            Price = 10320000, Square = 10.5f, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
                new Post {PostID = 5, UserID = 3, AddressID = 2, Title = "Cho thuê trọ tại ĐH BK HN", Description = "Trọ bao đẹp",
                            Price = 10320000, Square = 10.5f, BeingPosted = false, BeingRented = false,
                            CreatedAt = DateTime.Now, PublishedAt = null, ModifiedAt = null
                },
            });

            context.Images.AddRange(new Image[]
            {
                new Image {ImageID = 1, PostID = 1 , ImagePath = @"\phongtro1.jpg"},

            });

            context.Comments.AddRange(new Comment[]
            {
                new Comment {CommentID = 1, PostID =1, UserID = 2, Content = "Haha", CreatedAt = DateTime.Now},
                new Comment {CommentID = 2, PostID =1, UserID = 2, Content = "Hihi", CreatedAt = DateTime.Now},
                new Comment {CommentID = 3, PostID =2, UserID = 3, Content = "Hehe", CreatedAt = DateTime.Now},
                new Comment {CommentID = 4, PostID =2, UserID = 3, Content = "Huhu", CreatedAt = DateTime.Now},

            });

            context.Ratings.AddRange(new Rating[]
            {
                new Rating {RatingID = 1, PostID = 1, UserID = 3, Star = 5, CreatedAt = DateTime.Now},
                new Rating {RatingID = 2, PostID = 1, UserID = 2, Star = 2, CreatedAt = DateTime.Now},
                new Rating {RatingID = 3, PostID = 2, UserID = 2, Star = 2, CreatedAt = DateTime.Now},
                new Rating {RatingID = 4, PostID = 2, UserID = 3, Star = 5, CreatedAt = DateTime.Now},

            });

        }
    }
}
