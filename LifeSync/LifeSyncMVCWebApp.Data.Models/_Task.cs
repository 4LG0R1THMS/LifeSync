using LifeSyncMVCWebApp.Common;
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
    using static LifeSyncMVCWebApp.Common._ValidationConstants._Task;
    public class _Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; } // Assuming a relationship with IdentityUser

        [Required]
        [StringLength(
            maximumLength: TitleMaxLength,
            ErrorMessage = TitleMaxLengthErrorMessage)]
        public string Title { get; set; } = null!;

        [StringLength(
            maximumLength: DescriptionMaxLength,
            ErrorMessage = DescriptionMaxLengthErrorMessage)]
        public string Description { get; set; } = null!;

        [Required]
        public _PriorityEnum Priority { get; set; }

        [Required]
        public _StatusEnum Status { get; set; }
        public DateTime Deadline { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        // Nullable foreign key to reference Project (A Task may optionally belong to a Project)
        [ForeignKey(nameof(Project))]
        public int? ProjectId { get; set; }

        // Navigation properties
        public _ApplicationUser User { get; set; } = null!;
        public virtual _Project Project { get; set; }
    }
}
