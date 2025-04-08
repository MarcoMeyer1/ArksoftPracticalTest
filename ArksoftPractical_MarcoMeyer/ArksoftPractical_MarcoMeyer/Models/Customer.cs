using System.ComponentModel.DataAnnotations;

namespace ArksoftPractical_MarcoMeyer.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; } = null!;

        public string? Telephone { get; set; }
        public string? ContactName { get; set; }

        //I ended up using regex instead of the built in validation, due to the built in one returning valid even though the .com is missing

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Enter a valid email address (e.g. user@domain.com)")]
        public string? ContactEmail { get; set; }

        public string? VatNumber { get; set; }
    }
}
