using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    public class _Note
    {
        [Key]
        public int NoteId { get; set; }
        public Guid UserId { get; set; } // Assuming a relationship with a User entity
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime DateCreated { get; set; }

        // Navigation property for the User (if there's a relationship)
        public _ApplicationUser User { get; set; }
    }
}
