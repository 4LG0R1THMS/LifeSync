using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    public class _Task
    {
        [Key]
        public int TaskId { get; set; }
    
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; } // Assuming a relationship with IdentityUser
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Priority { get; set; } = null!;// Consider enum for Priority (Low, Medium, High)
        public string Status { get; set; } = null!;// Consider enum for Status (Pending, InProgress, Completed)
        public DateTime Deadline { get; set; }
        public DateTime DateCreated { get; set; }

        // Navigation property
        public _ApplicationUser User { get; set; } = null!;
    }
}
