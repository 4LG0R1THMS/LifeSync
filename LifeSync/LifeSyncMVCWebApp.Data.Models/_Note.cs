using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    using static LifeSyncMVCWebApp.Common._ValidationConstants._Note;
    public class _Note
    {
        [Key]
        public int NoteId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; } // Assuming a relationship with a User entity

        [Required]
        [StringLength(
            maximumLength: TitleMaxLength,
            ErrorMessage = TitleMaxLengthErrorMessage)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(
            maximumLength:ContentMaxLength,
            ErrorMessage = ContentMaxLengthErrorMessage)]
        public string Content { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }

        // Navigation property for the User (if there's a relationship)
        public _ApplicationUser User { get; set; }
    }
}
