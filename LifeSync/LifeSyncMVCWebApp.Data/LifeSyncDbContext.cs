using LifeSyncMVCWebApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
