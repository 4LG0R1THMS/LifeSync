using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    using static LifeSyncMVCWebApp.Common._ValidationConstants._Contact;
    public class _Contact
    {
        [Key]
        public int ContactId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(
            maximumLength: NameMaxLength,
            ErrorMessage = NameMaxLengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(
            maximumLength: EmailMaxLength,
            ErrorMessage = EmailMaxLengthErrorMessage)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(
            maximumLength: PhoneMaxLength,
            ErrorMessage = PhoneMaxLengthErrorMessage)]
        public string Phone { get; set; } = null!;

        [Required]
        [StringLength(
            maximumLength: AddressMaxLength,
            ErrorMessage = AddressMaxLengthErrorMessage)]
        public string Address { get; set; } = null!;

        // Navigation property
        public _ApplicationUser User { get; set; } = null!;
    }
}
