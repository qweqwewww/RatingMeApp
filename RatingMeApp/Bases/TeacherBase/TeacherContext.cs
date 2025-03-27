using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingMeApp.Bases.TeacherBase
{
    class TeacherContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=teachersBase.db");
        }
    }
}
