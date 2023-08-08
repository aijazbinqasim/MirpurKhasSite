using System.ComponentModel.DataAnnotations;

namespace Hello_World.Models
{
    public class Product
    {
        

        //[DataType(DataType.Password)]
        [Required(ErrorMessage = "Please provide Title")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please provide Valid Title")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Url]
        [Display(Name = "Phone Number")]

        public string Phone { get; set; }

       
    }
}

