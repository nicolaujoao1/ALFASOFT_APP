using System.ComponentModel.DataAnnotations;

namespace ALFASOFT.Application.DTOs
{
    public class ContactDTO
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Contact must be exactly 9 digits")]
        public string ContactNumber{ get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailAddress { get; set; }
    }
}
