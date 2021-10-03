using System.ComponentModel.DataAnnotations;
using System;
namespace FormSubmission.Models
{
    public class User
    {
        [Required (ErrorMessage ="First Name Needed!")]
        [MinLength(4, ErrorMessage ="Needs between 4 and 50 characters!")]
        public string FirstName{get;set;}

        [Required (ErrorMessage ="Last Name Needed!")]
        [MinLength(4,ErrorMessage ="Needs between 4 and 50 characters!")]
        public string LastName{get;set;}

        [Required (ErrorMessage ="Age Needed!")]
        [Range(0,150, ErrorMessage ="Needs number between 0 and 150!")]
        public int Age{get;set;}

        [Required (ErrorMessage ="Email Needed!")]
        [MinLength(4,ErrorMessage ="Needs between 4 and 50 characters!")]
        public string Email{get;set;}

        [Required (ErrorMessage ="Password Needed!")]
        [MinLength(4,ErrorMessage ="Needs between 4 and 50 characters!")]
        public string Password{get;set;}

        [Required]
        [FutureDateAttribute]
        public DateTime FavDate {get;set;}
    }



    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value is DateTime)
            {
                DateTime checkMe = (DateTime)value;
                if(checkMe > DateTime.Now)
                {
                    return new ValidationResult("That's the Future");                        
                }
                else 
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("Not a date");
            }
        }
    }
}