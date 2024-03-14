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
    using static LifeSyncMVCWebApp.Common._ValidationConstants._Project;
    public class _Project
    {
        [Key]
        public int ProjectId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(
            maximumLength: NameMaxLength,
            ErrorMessage = NameMaxLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [StringLength(
            maximumLength: DescriptionMaxLength,
            ErrorMessage = DescriptionMaxLengthErrorMessage)]
        public string Description { get; set; } = null!;
        public DateTime Deadline { get; set; }

        [Required]
        public _StatusEnum Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        // Navigation property
        public _ApplicationUser User { get; set; }

        // Navigation property to the tasks (One Project to Many Tasks relationship)
        public virtual ICollection<_Task> Tasks { get; set; } = new List<_Task>();
    }
}
