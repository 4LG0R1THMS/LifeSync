using LifeSyncMVCWebApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LifeSyncMVCWebApp.Data.Models.Enums;

namespace LifeSyncMVCWebApp.Data
{
    //using Task = LifeSyncMVCWebApp.Data.Models.Task;
    public class LifeSyncDbContext : IdentityDbContext<_ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public LifeSyncDbContext(DbContextOptions<LifeSyncDbContext> options)
            : base(options)
        {
        }
        public DbSet<_ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<_Contact> Contacts { get; set; } = null!;
        public DbSet<_Event> Events { get; set; } = null!;
        public DbSet<_Project> Projects { get; set; } = null!;
        public DbSet<_Note> Notes { get; set; } = null!;
        public DbSet<_Task> Tasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<_ApplicationUser>().HasData(
                new _ApplicationUser
                {
                    Id = Guid.Parse("c683a83b-82a9-4436-af59-0b980068a995")
                }
            );

            modelBuilder.Entity<_Project>().HasData(
                new _Project
                {
                    ProjectId = 1,
                    UserId = Guid.Parse("c683a83b-82a9-4436-af59-0b980068a995"),
                    Name = "Project Alpha",
                    Description = "This is a sample project",
                    Deadline = DateTime.Now.AddMonths(1),
                    Status = _StatusEnum.Pending,
                    DateCreated = DateTime.Now
                }
            // Add more projects as needed
            );

            modelBuilder.Entity<_Task>().HasData(
                new _Task
                {
                    TaskId = 1,
                    ProjectId = 1, // assuming this task belongs to the first project
                    UserId = Guid.Parse("c683a83b-82a9-4436-af59-0b980068a995"),
                    Title = "Task 1",
                    Description = "This is a sample task for Project Alpha",
                    Priority = _PriorityEnum.Medium,
                    Status = _StatusEnum.Pending,
                    Deadline = DateTime.Now.AddDays(15),
                    DateCreated = DateTime.Now
                },
                new _Task
                {
                    TaskId = 2,
                    ProjectId = 1, // assuming this task belongs to the first project
                    UserId = Guid.Parse("c683a83b-82a9-4436-af59-0b980068a995"),
                    Title = "Task 2",
                    Description = "This is a sample task222 for Project Alpha",
                    Priority = _PriorityEnum.Low,
                    Status = _StatusEnum.Completed,
                    Deadline = DateTime.Now.AddDays(15),
                    DateCreated = DateTime.Now
                }
            // Add more tasks as needed
            );
        }
    }
}
