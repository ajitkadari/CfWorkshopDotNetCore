using System;
using Microsoft.EntityFrameworkCore;

namespace CfWorkshopDotNetCore.Models
{
    public class CfWorkshopContext : DbContext
    {
        public CfWorkshopContext (DbContextOptions<CfWorkshopContext> options)
            : base(options)
        {
        }

        public DbSet<CfWorkshopDotNetCore.Models.Note> Note { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Note>().Property(b => b.Created).HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Note>().HasData(
                    new Note
                    {
                        ID = 1,
                        Text = "Note #1",
                        Created = DateTime.Now
                    },
                    new Note
                    {
                        ID = 2,
                        Text = "Note #2",
                        Created = DateTime.Now
                    },
                    new Note
                    {
                        ID = 3,
                        Text = "Note #3",
                        Created = DateTime.Now
                    }
            );
        }

    }
}
