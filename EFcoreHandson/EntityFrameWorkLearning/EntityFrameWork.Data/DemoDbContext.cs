using EntityFramework.Data.Entities;
using EntityFrameWork.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Data
{
    public class DemoDbContext:DbContext
    {


        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeEducation> EmployeeEducations { get; set; }

        public DbSet<ClassRoom> ClassRooms { get; set; }

        public DbSet<Teacher> Teachers { get; set; }


        public DemoDbContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SWATI;Database=Study;Trusted_Connection=True;");

        }


    }
}
