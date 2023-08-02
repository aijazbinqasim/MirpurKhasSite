using System.ComponentModel.DataAnnotations;

namespace Hello_World.Models
{
    public class Product
    {
        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Please provide FullName")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please provide Valid Name")]
        public string FullName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]

        public string Email { get; set; }

       
    }
}

