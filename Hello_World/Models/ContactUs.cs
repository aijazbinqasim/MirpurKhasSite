using System.ComponentModel.DataAnnotations;

namespace MirpurKhasSite.Models
{
    public class ContactUs
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(10, MinimumLength = 2)]
        public string FullName { get; set; }

        [Required(ErrorMessage ="Please provide Phone")]
        [Phone] 
        public string Phone { get; set; }




        [Required(ErrorMessage = "Please enter your email address")]

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Provide Subject")]
        [StringLength(10, MinimumLength = 10)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please Provide Message")]
        [StringLength(15, MinimumLength = 15)]
        public string Message { get; set; }





    }
}

