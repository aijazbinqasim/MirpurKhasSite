using System.ComponentModel.DataAnnotations;

namespace MirpurKhasSite.Models
{
    public class ContactUs
    {
        [Required(ErrorMessage = "Please provide FullName")]
       
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please provide Valid Name")]
        
        public string FullName { get; set; }

        [Required(ErrorMessage ="Please provide Phone")]
        [Phone] 
        public string Phone { get; set; }

        

        
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        public string Subject { get; set; }
        public string Message { get; set; }





    }
}

