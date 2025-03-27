using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingMeApp.Bases.ScheduleBase
{
    class ScheduleContext : DbContext
    {
        public DbSet<Schedule> Schedules { get; set; } = null!;
        public DbSet<Date> Dates { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=scheduleBase.db");
        }
    }
}
