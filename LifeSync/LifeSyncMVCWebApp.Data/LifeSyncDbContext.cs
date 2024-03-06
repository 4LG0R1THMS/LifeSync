using LifeSyncMVCWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LifeSyncMVCWebApp.Data
{
    //using Task = LifeSyncMVCWebApp.Data.Models.Task;
    public class LifeSyncDbContext : DbContext
    {
        public DbSet<_Contact> Contacts { get; set; } = null!;
        public DbSet<_Event> Events { get; set; } = null!;
        public DbSet<_Project> Projects { get; set; } = null!;
        public DbSet<_Note> Notes { get; set; } = null!;
        public DbSet<_Task> Tasks { get; set; } = null!;
    }
}
