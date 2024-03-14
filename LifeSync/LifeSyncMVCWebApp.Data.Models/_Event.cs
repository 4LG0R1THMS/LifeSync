using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    using static LifeSyncMVCWebApp.Common._ValidationConstants._Event;
    public class _Event
    {
        [Key]
        public int EventId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(
            maximumLength: TitleMaxLength,
            ErrorMessage = TitleMaxLengthErrorMessage)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(
            maximumLength: DescriptionMaxLength,
            ErrorMessage = DescriptionMaxLengthErrorMessage)]
        public string Description { get; set; } = null!;
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        [StringLength(
            maximumLength: LocationMaxLength,
            ErrorMessage =LocationMaxLengthErrorMessage)]
        public string? Location { get; set; }

        // Navigation property
        public _ApplicationUser User { get; set; } = null!;
    }
}
