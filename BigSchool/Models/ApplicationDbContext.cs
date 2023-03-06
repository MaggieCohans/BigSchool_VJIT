using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories{ get; set; } //Nhớ thêm cái này vô trước khi add-migration 'createTable' thì mới ra trong database
        public DbSet<Course> Courses{ get; set; }
public ApplicationDbContext()
            : base("MaggieDb", throwIfV1Schema: false) //nhớ đổi tên trong base
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}