using LifeSyncMVCWebApp.Data.Models.Enums;
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
        public _PriorityEnum Priority { get; set; }
        public _StatusEnum Status { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime DateCreated { get; set; }

        // Nullable foreign key to reference Project (A Task may optionally belong to a Project)
        [ForeignKey(nameof(Project))]
        public int? ProjectId { get; set; }

        // Navigation properties
        public _ApplicationUser User { get; set; } = null!;
        public virtual _Project Project { get; set; }
    }
}
