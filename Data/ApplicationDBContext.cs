using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;
namespace NetCore.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<NetCore.Models.Movie> Movie { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<NetCore.Models.Student> Student { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<NetCore.Models.KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanViens { get; set;}
        public DbSet<NetCore.Models.PhongBan> PhongBan { get; set; }
    }
}

    
