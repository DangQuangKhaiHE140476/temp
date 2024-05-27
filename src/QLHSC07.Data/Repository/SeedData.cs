using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QLHSC07.Entity.IdentityAccess;
using QLHSC07.Entity.QLHSC07_Entities;
using System;
using System.Collections.Generic;

namespace QLHSC07.Data.Repository
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //seed admin user
            var hasher = new PasswordHasher<User>();
            var roleId = "20f52440-0318-401f-9ca6-4bc5980e393e";
            var userId = "a7cd6c60-cea7-4aae-a750-514e1d74d1e8";
            List<User> users = new List<User>();
            List<Role> roles = new List<Role>();
            roles.Add(new Role { 
                Code="ADMIN",
                Id=roleId,
                Name="ADMIN"
            });
            modelBuilder.Entity<Role>().HasData(roles);

            users.Add(new User
            {
                Id = userId,
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "0968883898",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                FullName = "Administrator",
                Sex = true,
                Address = "Hà Nội",
                CreatedBy = "Administrator",
                ModifiedBy = "Administrator",
                DocumentUploadId = null,
                Status = true,
                Description = "Administrator",
                DateOfBirth = new DateTime(2021, 2, 28),
                //PasswordHash = hasher.HashPassword(null, "123@123a"),
                PasswordHash= "AQAAAAEAACcQAAAAEIwpHgrYjpij2oKnyfSjRuvmxiEK9ItWF2UjGWCHuJ9iyqMNd3ymn4XrRs5dqRRSMQ==",
                SecurityStamp = "ce58ce2d-d3bf-45ab-86f2-15ac96b88104"
            });

            modelBuilder.Entity<User>().HasData(users);

            List<UserRole> userRoles = new List<UserRole>();
            userRoles.Add(new UserRole {
                RoleId=roleId,
                UserId=userId
            });
            modelBuilder.Entity<UserRole>().HasData(userRoles);
            AddField(modelBuilder);
            AdministrativeFormalities(modelBuilder);
        }
        public static void AdministrativeFormalities(this ModelBuilder modelBuilder)
        {

        }
        public static void AddField(this ModelBuilder modelBuilder)
        {
            List<Field> data = new List<Field>();
            data.Add(new Field
            {
                Id = 273,
                Name = "An toàn bức xạ và hạt nhân",
                Code = "G06-KC01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 274,
                Name = "An toàn đập, hồ chứa thuỷ điện",
                Code = "G02-CT26",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 2,
                Name = "An toàn thông tin",
                Code = "G14-TT01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 3,
                Name = "An toàn thực phẩm",
                Code = "G02-CT01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 4,
                Name = "An toàn thực phẩm và Dinh dưỡng",
                Code = "G18-YT01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 5,
                Name = "An toàn vệ sinh lao động",
                Code = "G02-CT02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 6,
                Name = "An toàn, vệ sinh lao động",
                Code = "G07-LĐ01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 7,
                Name = "Bán đấu giá tài sản",
                Code = "G15-TP01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 8,
                Name = "Bản quyền tác giả",
                Code = "G16-VH01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 9,
                Name = "Báo chí",
                Code = "G08-NG01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 10,
                Name = "Báo chí",
                Code = "G11-QP17",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 11,
                Name = "Báo chí",
                Code = "G14-TT02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 12,
                Name = "Bảo hiểm",
                Code = "G12-TC14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 13,
                Name = "Bảo hiểm xã hội",
                Code = "G07-LĐ02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 14,
                Name = "Bảo trợ xã hội",
                Code = "G07-LĐ03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 15,
                Name = "Bảo vệ thực vật",
                Code = "G10-NN01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 16,
                Name = "Biển và hải đảo",
                Code = "G13-TN01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 17,
                Name = "Bình đẳng giới",
                Code = "G07-LĐ05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 18,
                Name = "Bồi thường nhà nước",
                Code = "G15-TP02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 19,
                Name = "Bưu chính",
                Code = "G14-TT03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 20,
                Name = "Các cơ sở giáo dục khác",
                Code = "BGD-GD15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 21,
                Name = "Cải cách hành chính",
                Code = "G09-NV01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 22,
                Name = "Cấp hộ chiếu, giấy thông hành, công hàm đề nghị cấp thị thực",
                Code = "G08-NG02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 23,
                Name = "Cấp, quản lý căn cước công dân",
                Code = "G01-CA01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 24,
                Name = "Cấp thị thực, gia hạn tạm trú",
                Code = "G08-NG05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 25,
                Name = "Chăn nuôi",
                Code = "G10-NN02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 26,
                Name = "Chế biến và phát triển thị trường Nông sản",
                Code = "G10-NN03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 27,
                Name = "Chính quyền địa phương",
                Code = "G09-NV02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 28,
                Name = "Chính sách",
                Code = "G11-QP03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 29,
                Name = "Chính sách Thuế",
                Code = "G12-TC01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 30,
                Name = "Chứng khoán",
                Code = "G12-TC02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 31,
                Name = "Chứng nhận lãnh sự, hợp pháp hóa lãnh sự",
                Code = "G08-NG03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 32,
                Name = "Chứng thực",
                Code = "G15-TP03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 33,
                Name = "Công chức, viên chức",
                Code = "G09-NV03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 34,
                Name = "Công chứng",
                Code = "G15-TP04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 35,
                Name = "Công chứng, chứng thực",
                Code = "G08-NG04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 36,
                Name = "Công nghệ thông tin, điện tử",
                Code = "G14-TT04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 37,
                Name = "Công nghiệp địa phương",
                Code = "G02-CT03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 38,
                Name = "Công nghiệp nặng",
                Code = "G02-CT04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 39,
                Name = "Công nghiệp tiêu dùng",
                Code = "G02-CT05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 40,
                Name = "Công tác dân tộc",
                Code = "G21-UB01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 41,
                Name = "Công tác lãnh sự",
                Code = "CTLS",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 42,
                Name = "Công tác thanh niên",
                Code = "G09-NV04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 43,
                Name = "Cơ sở vật chất và thiết bị trường học",
                Code = "G03-GD01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 44,
                Name = "Đăng kiểm",
                Code = "G04-GT01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 45,
                Name = "Đăng ký biện pháp bảo đảm",
                Code = "G15-TP05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 46,
                Name = "Đăng ký công dân",
                Code = "G08-NG06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 47,
                Name = "Đăng ký, quản lý con dấu",
                Code = "G01-CA04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 48,
                Name = "Đăng ký, quản lý cư trú",
                Code = "G01-CA05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 49,
                Name = "Đăng ký, quản lý phương tiện giao thông đường bộ",
                Code = "G01-CA06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 50,
                Name = "Dân số",
                Code = "G18-YT02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 51,
                Name = "Đào tạo, bồi dưỡng cán bộ công chức, viên chức",
                Code = "G09-NV05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 52,
                Name = "Đào tạo, Nghiên cứu khoa học và Công nghệ thông tin",
                Code = "G18-YT03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 53,
                Name = "Đào tạo với nước ngoài",
                Code = "G03-GD02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 54,
                Name = "Đất đai",
                Code = "G13-TN02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 55,
                Name = "Dầu khí",
                Code = "G02-CT06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 56,
                Name = "Đấu thầu",
                Code = "G05-KD02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 57,
                Name = "Đầu tư",
                Code = "G12-TC03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 58,
                Name = "Đầu tư bằng vốn hỗ trợ phát triển chính thức (ODA) và viện trợ không hoàn lại không thuộc hỗ trợ phát triển chính thức",
                Code = "G05-KD01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 59,
                Name = "Đầu tư tại Việt nam",
                Code = "G05-KD03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 60,
                Name = "Đầu tư từ Việt nam ra nước ngoài",
                Code = "G05-KD04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 61,
                Name = "Đầu tư vào nông nghiệp, nông thôn",
                Code = "G05-KD05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 62,
                Name = "Địa chất và khoáng sản",
                Code = "G13-TN03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 63,
                Name = "Dịch vụ cung cấp điện mới",
                Code = "DL-DVDM",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 64,
                Name = "Dịch vụ du lịch khác",
                Code = "G16-VH18",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 65,
                Name = "Dịch vụ thương mại",
                Code = "G02-CT07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 66,
                Name = "Dịch vụ trong quá trình thực hiện HĐMBĐ",
                Code = "DL-DVMBD",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 67,
                Name = "Điện",
                Code = "G02-CT08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 68,
                Name = "Điện ảnh",
                Code = "G16-VH03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 69,
                Name = "Di sản văn hóa",
                Code = "G16-VH02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 70,
                Name = "Đo đạc, bản đồ và thông tin địa lý",
                Code = "G13-TN04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 71,
                Name = "Du lịch",
                Code = "G16-VH21",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 72,
                Name = "Dược phẩm",
                Code = "G18-YT04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 73,
                Name = "Đường bộ",
                Code = "G04-GT02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 74,
                Name = "Đường sắt",
                Code = "G04-GT03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 75,
                Name = "Đường thủy nội địa",
                Code = "G04-GT04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 76,
                Name = "Dự trữ",
                Code = "G12-TC10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 77,
                Name = "Gia đình",
                Code = "G16-VH04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 78,
                Name = "Giải quyết khiếu nại",
                Code = "G20-TH02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 79,
                Name = "Giải quyết tố cáo",
                Code = "G20-TH03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 80,
                Name = "Giám định nhà nước về chất lượng công trình xây dựng",
                Code = "G17-XD01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 81,
                Name = "Giám định thương mại",
                Code = "G02-CT27",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 82,
                Name = "Giám định tư pháp",
                Code = "G15-TP06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 83,
                Name = "Giám định y khoa",
                Code = "G18-YT05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 84,
                Name = "Giáo dục Chuyên nghiệp",
                Code = "G03-GD03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 85,
                Name = "Giáo dục Đại học",
                Code = "G03-GD04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 86,
                Name = "Giáo dục Dân tộc",
                Code = "G03-GD05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 87,
                Name = "Giáo dục đào tạo thuộc hệ thống giáo dục quốc dân và các cơ sở khác",
                Code = "BGD-GD15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 88,
                Name = "Giáo dục Mầm non",
                Code = "G03-GD06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 89,
                Name = "Giáo dục nghề nghiệp",
                Code = "G07-LĐ06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 90,
                Name = "Giáo dục Quốc phòng",
                Code = "G03-GD07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 91,
                Name = "Giáo dục Thường xuyên",
                Code = "G03-GD08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 92,
                Name = "Giáo dục Tiểu học",
                Code = "G03-GD09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 93,
                Name = "Giáo dục trung học",
                Code = "G03-GD10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 94,
                Name = "Giáo dục Trung học",
                Code = "G03-GD10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 95,
                Name = "Giáo dục và Đào tạo thuộc hệ thống giáo dục quốc dân",
                Code = "G03-GD11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 96,
                Name = "Hải quan",
                Code = "G12-TC04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 97,
                Name = "Hàng Hải",
                Code = "G04-GT05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 98,
                Name = "Hàng không",
                Code = "G04-GT06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 99,
                Name = "Hành chính sự nghiệp",
                Code = "G12-TC16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 100,
                Name = "Hạ tầng kỹ thuật",
                Code = "G17-XD02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 101,
                Name = "Hạ tầng kỹ thuật đô thị và khu công nghiệp, khu kinh tế và khu công nghệ cao",
                Code = "G17-XD03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 102,
                Name = "Hệ thống văn bằng, chứng chỉ",
                Code = "G03-GD14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 103,
                Name = "Hóa chất",
                Code = "G02-CT09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 104,
                Name = "Hòa giải thương mại",
                Code = "G15-TP08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 105,
                Name = "Hoạt động của các tổ chức hợp tác, nghiên cứu song phương",
                Code = "G08-NG08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 106,
                Name = "Hoạt động của các tổ chức phi chính phủ nước ngoài",
                Code = "G08-NG09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 107,
                Name = "Hoạt động khoa học và công nghệ",
                Code = "G06-KC02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 108,
                Name = "Hoạt động ngoại hối",
                Code = "G19-NH05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 109,
                Name = "Hoạt động xây dựng",
                Code = "G17-XD11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 110,
                Name = "Hồi hương",
                Code = "G08-NG10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 111,
                Name = "Hội nghị, hội thảo quốc tế",
                Code = "G08-NG13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 112,
                Name = "Hợp tác quốc tế",
                Code = "G17-XD04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 113,
                Name = "Hợp tác quốc tế",
                Code = "G16-VH16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 114,
                Name = "Hợp tác quốc tế",
                Code = "G12-TC21",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 115,
                Name = "Hợp tác quốc tế",
                Code = "G10-NN04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 116,
                Name = "Hợp tác quốc tế",
                Code = "G09-NV06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 117,
                Name = "Hợp tác quốc tế",
                Code = "G18-YT06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 118,
                Name = "Hợp tác quốc tế",
                Code = "G13-TN05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 119,
                Name = "Hộ tịch",
                Code = "G15-TP07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 120,
                Name = "Hộ tịch",
                Code = "G08-NG07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 121,
                Name = "Hỗ trợ doanh nghiệp nhỏ và vừa",
                Code = "G05-KD06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 122,
                Name = "Hỗ trợ pháp lý cho doanh nghiệp nhỏ và vừa",
                Code = "G15-TP19",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 123,
                Name = "Karaoke, Vũ trường",
                Code = "G16-VH07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 124,
                Name = "Kế hoạch - tài chính",
                Code = "G12-TC05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 125,
                Name = "Kế hoạch - Tài chính",
                Code = "G09-NV17",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 126,
                Name = "Kế toán, kiểm toán",
                Code = "G12-TC06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 127,
                Name = "Khách sạn",
                Code = "G16-VH06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 128,
                Name = "Khám bệnh, chữa bệnh",
                Code = "G18-YT07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 129,
                Name = "Khen thưởng",
                Code = "G11-QP20",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 130,
                Name = "Khiếu nại, tố cáo",
                Code = "G01-CA07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 131,
                Name = "Khí tượng, thủy văn và Biến đổi khí hậu",
                Code = "G13-TN06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 132,
                Name = "Khoa học công nghệ",
                Code = "G13-TN08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 133,
                Name = "Khoa học công nghệ và môi trường",
                Code = "G17-XD05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 134,
                Name = "Khoa học, Công nghệ và Môi trường",
                Code = "G10-NN05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 135,
                Name = "Khoa học và công nghệ",
                Code = "G06-KC06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 136,
                Name = "Kho bạc",
                Code = "G12-TC07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 137,
                Name = "Kinh doanh bất động sản",
                Code = "G17-XD06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 138,
                Name = "Kinh doanh khí",
                Code = "G02-CT10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 139,
                Name = "Kinh tế hợp tác và Phát triển nông thôn",
                Code = "G10-NN06",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 140,
                Name = "Kinh tế xây dựng",
                Code = "G17-XD07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 141,
                Name = "Lâm nghiệp",
                Code = "G10-NN07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 142,
                Name = "Lao động",
                Code = "G07-LĐ07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 143,
                Name = "Lĩnh vực khác",
                Code = "BGT-LVK",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 144,
                Name = "Lĩnh vực khác",
                Code = "LVK",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 145,
                Name = "Lĩnh vực khác",
                Code = "NHCS-LVK",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 146,
                Name = "Luật sư",
                Code = "G15-TP09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 147,
                Name = "Lữ hành",
                Code = "G16-VH05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 148,
                Name = "Lưu thông hàng hóa trong nước",
                Code = "G02-CT11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 149,
                Name = "Lý lịch tư pháp",
                Code = "G15-TP10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 150,
                Name = "Miễn thị thực",
                Code = "G08-NG12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 151,
                Name = "Môi trường",
                Code = "G13-TN09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 152,
                Name = "Mỹ phẩm",
                Code = "G18-YT08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 153,
                Name = "Mỹ thuật, nhiếp ảnh, triển lãm",
                Code = "G16-VH09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 154,
                Name = "Năng lượng",
                Code = "G02-CT12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 155,
                Name = "Nghệ thuật biểu diễn",
                Code = "G16-VH10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 156,
                Name = "Nghĩa vụ quân sự",
                Code = "G11-QP10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 157,
                Name = "Người có công",
                Code = "G07-LĐ09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 158,
                Name = "Người lao động Việt Nam đi làm việc ở nước ngoài theo hợp đồng",
                Code = "G07-LĐ12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 159,
                Name = "Nhà ở và công sở",
                Code = "G17-XD08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 160,
                Name = "Nhập khẩu văn hoá phẩm nhằm mục đích kinh doanh",
                Code = "G16-VH19",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 161,
                Name = "Nông nghiệp",
                Code = "G10-NN16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 162,
                Name = "Nuôi con nuôi",
                Code = "G15-TP11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 163,
                Name = "Pháp chế",
                Code = "G09-NV16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 164,
                Name = "Pháp chế",
                Code = "G12-TC24",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 165,
                Name = "Phát thanh, truyền hình và thông tin điện tử",
                Code = "G14-TT05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 166,
                Name = "Phát triển đô thị",
                Code = "G17-XD09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 167,
                Name = "Phát triển tiềm lực khoa học và công nghệ",
                Code = "G06-KC05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 168,
                Name = "Phổ biến giáo dục pháp luật",
                Code = "G15-TP12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 169,
                Name = "Phòng, chống tệ nạn xã hội",
                Code = "G07-LĐ10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 170,
                Name = "Phòng, chống tham nhũng",
                Code = "G20-TH01",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 171,
                Name = "Phòng, chống thiên tai",
                Code = "G10-NN08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 172,
                Name = "Quảng cáo",
                Code = "G16-VH12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 173,
                Name = "Quản lý Cạnh tranh",
                Code = "G02-CT14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 174,
                Name = "Quản lý chất lượng nông lâm sản và thủy sản",
                Code = "G10-NN09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 175,
                Name = "Quản lý công nghệ thông tin",
                Code = "G11-QP15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 176,
                Name = "Quản lý công sản",
                Code = "G12-TC09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 177,
                Name = "Quản lý doanh nghiệp",
                Code = "G10-NN10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 178,
                Name = "Quản lý doanh nghiệp",
                Code = "G17-XD10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 179,
                Name = "Quản lý giá",
                Code = "G12-TC11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 180,
                Name = "Quản lý hoạt động xây dựng",
                Code = "G17-XD11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 181,
                Name = "Quản lý lao động ngoài nước",
                Code = "G07-LĐ13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 182,
                Name = "Quản lý ngành nghề đầu tư, kinh doanh có điều kiện về an ninh, trật tự",
                Code = "G01-CA09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 183,
                Name = "Quản lý ngân sách nhà nước",
                Code = "BTC-NSNN",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 184,
                Name = "Quản lý nhà và thị trường bất động sản",
                Code = "G17-XD12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 185,
                Name = "Quản lý nợ",
                Code = "G12-TC12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 186,
                Name = "Quản lý quỹ ngân sách, quỹ dự trữ nhà nước và các quỹ tài chính khác của Nhà nước",
                Code = "BTC-QLNS",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 187,
                Name = "Quản lý sử dụng vũ khí, súng săn, vật liệu nổ, công cụ hỗ trợ",
                Code = "G16-VH20",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 188,
                Name = "Quản lý thuế, phí, lệ phí và thu khác của ngân sách nhà nước",
                Code = "BTC_QLT",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 189,
                Name = "Quản lý vũ khí, vật liệu nổ, công cụ hỗ trợ và pháo",
                Code = "G01-CA10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 190,
                Name = "Quản lý xây dựng công trình",
                Code = "G10-NN11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            //data.Add(new Field
            //{
            //    Id = 191,
            //    Name = "Quản lý xuất nhập cảnh",
            //    Code = "G01-CA11",
            //    CreatedBy = "admin",
            //    CreatedDate = DateTime.Now,
            //    ModifiedBy = "admin",
            //    ModifiedDate = DateTime.Now
            //});
            data.Add(new Field
            {
                Id = 192,
                Name = "Quản tài viên",
                Code = "G15-TP13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 193,
                Name = "Quốc phòng, an ninh",
                Code = "G12-TC20",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 194,
                Name = "Quốc tịch",
                Code = "G08-NG11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 195,
                Name = "Quốc tịch",
                Code = "G15-TP14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 196,
                Name = "Quy chế thi, tuyển sinh",
                Code = "G03-GD12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 197,
                Name = "Quy hoạch xây dựng, kiến trúc",
                Code = "G17-XD13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 198,
                Name = "Sở hữu trí tuệ",
                Code = "G06-KC03",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 199,
                Name = "Tài chính doanh nghiệp",
                Code = "G12-TC15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 200,
                Name = "Tài chính ngân hàng",
                Code = "G12-TC17",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 201,
                Name = "Tài chính y tế",
                Code = "G18-YT09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 202,
                Name = "Tài nguyên nước",
                Code = "G13-TN10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 203,
                Name = "Tần số vô tuyến điện",
                Code = "G14-TT07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 204,
                Name = "Thành lập và hoạt động của doanh nghiệp",
                Code = "G05-KD07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 205,
                Name = "Thành lập và hoạt động của hợp tác xã",
                Code = "G05-KD08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 206,
                Name = "Thành lập và hoạt động của hợp tác xã (liên hiệp hợp tác xã)",
                Code = "G05-KD09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 207,
                Name = "Thành lập và hoạt động của quỹ đầu tư khởi nghiệp sáng tạo",
                Code = "G05-KD-12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 208,
                Name = "Thành lập và hoạt động của tổ hợp tác",
                Code = "G05-KD-13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 209,
                Name = "Thành lập và hoạt động doanh nghiệp (hộ kinh doanh)",
                Code = "G05-KD10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 210,
                Name = "Thành lập và hoạt động doanh nghiệp xã hội",
                Code = "G05-KD11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 211,
                Name = "Thanh tra",
                Code = "G12-TC23",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 212,
                Name = "Thanh tra Bộ",
                Code = "G09-NV07",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 213,
                Name = "Thể dục thể thao",
                Code = "G16-VH14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 214,
                Name = "Thi đua - khen thưởng",
                Code = "G09-NV08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 215,
                Name = "Thi đua - khen thưởng",
                Code = "G12-TC13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 216,
                Name = "Thi đua, khen thưởng",
                Code = "G18-YT14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 217,
                Name = "Thi đua, khen thưởng",
                Code = "G02-CT16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 218,
                Name = "Thi đua – Khen thưởng",
                Code = "G16-VH15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 219,
                Name = "Thi hành án dân sự",
                Code = "G15-TP15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 220,
                Name = "Thi, tuyển sinh",
                Code = "G03-GD12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 221,
                Name = "Thông tin cơ sở",
                Code = "G14-TT08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 222,
                Name = "Thông tin đối ngoại",
                Code = "G14-TT09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 223,
                Name = "Thừa phát lại",
                Code = "G15-TP20",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 224,
                Name = "Thu Bảo hiểm xã hội, bảo hiểm y tế, bảo hiểm thất nghiệp, BHTNLĐ-BNN",
                Code = "BHXH-Thu",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 225,
                Name = "Thực hiện chính sách bảo hiểm xã hội",
                Code = "BHXH-CSBH",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 226,
                Name = "Thực hiện chính sách bảo hiểm xã hội",
                Code = "G24-02",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 227,
                Name = "Thực hiện chính sách bảo hiểm y tế",
                Code = "BHXH-THCS",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 228,
                Name = "Thuế",
                Code = "G12-TC18",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 229,
                Name = "Thương mại quốc tế",
                Code = "G02-CT19",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 230,
                Name = "Thư viện",
                Code = "G16-VH11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 231,
                Name = "Thú y",
                Code = "G10-NN12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 232,
                Name = "Thủy lợi",
                Code = "G10-NN13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 233,
                Name = "Thủy sản",
                Code = "G10-NN14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 234,
                Name = "Tiền lương",
                Code = "G07-LĐ08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 235,
                Name = "Tiền lương",
                Code = "G09-NV09",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 236,
                Name = "Tiếp công dân",
                Code = "G20-TH04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 237,
                Name = "Tiêu chuẩn đo lường chất lượng",
                Code = "G06-KC04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 238,
                Name = "Tiêu chuẩn nhà giáo, cán bộ quản lý giáo dục",
                Code = "G03-GD13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 239,
                Name = "Tin học - Thống kê",
                Code = "G12-TC19",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 240,
                Name = "Tổ chức - Biên chế",
                Code = "G09-NV12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 241,
                Name = "Tổ chức cán bộ",
                Code = "BLD-TCCB",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 242,
                Name = "Tổ chức cán bộ",
                Code = "G12-TC22",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 243,
                Name = "Tổ chức cán bộ",
                Code = "G09-NV10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 244,
                Name = "Tổ chức cán bộ",
                Code = "G18-YT10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 245,
                Name = "Tổ chức phi chính phủ",
                Code = "G09-NV11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 246,
                Name = "Tổng hợp",
                Code = "G09-NV14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 247,
                Name = "Tổng hợp",
                Code = "G13-TN11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 248,
                Name = "Tôn giáo Chính phủ",
                Code = "G09-NV13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 249,
                Name = "Trang thiết bị và công trình y tế",
                Code = "G18-YT11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 250,
                Name = "Trẻ em",
                Code = "G07-LĐ04",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 251,
                Name = "Trợ giúp pháp lý",
                Code = "G15-TP16",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 252,
                Name = "Trọng tài thương mại",
                Code = "G15-TP17",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 253,
                Name = "Trồng trọt",
                Code = "G10-NN15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 254,
                Name = "Tư vấn pháp luật",
                Code = "G15-TP18",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 255,
                Name = "Văn bằng, chứng chỉ",
                Code = "G03-GD14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 256,
                Name = "Văn hóa",
                Code = "G16-VH13",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 257,
                Name = "Văn hóa cơ sở",
                Code = "G16-VH08",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 258,
                Name = "Văn phòng",
                Code = "G09-NV18",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 259,
                Name = "Văn phòng",
                Code = "G12-TC25",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 260,
                Name = "Văn thư và Lưu trữ nhà nước",
                Code = "G09-NV15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 261,
                Name = "Vật liệu nổ công nghiệp, tiền chất thuốc nổ",
                Code = "G02-CT21",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 262,
                Name = "Vật liệu xây dựng",
                Code = "G17-XD14",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 263,
                Name = "Việc làm",
                Code = "G07-LĐ11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 264,
                Name = "Viễn thám",
                Code = "G13-TN12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 265,
                Name = "Viễn thông và Internet",
                Code = "G14-TT10",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 266,
                Name = "Xây dựng",
                Code = "G17-XD15",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 267,
                Name = "Xuất Bản, In và Phát hành",
                Code = "G14-TT11",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 268,
                Name = "Xuất nhập khẩu",
                Code = "G02-CT22",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 269,
                Name = "Xuất nhập khẩu văn hóa phẩm không nhằm mục đích kinh doanh",
                Code = "G16-VH17",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 270,
                Name = "Xúc tiến thương mại",
                Code = "G02-CT23",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 271,
                Name = "Xử lý đơn thư",
                Code = "G20-TH05",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            data.Add(new Field
            {
                Id = 272,
                Name = "Y tế Dự phòng",
                Code = "G18-YT12",
                CreatedBy = "admin",
                CreatedDate = DateTime.Now,
                ModifiedBy = "admin",
                ModifiedDate = DateTime.Now
            });
            modelBuilder.Entity<Field>().HasData(data);
        }
    }
}
