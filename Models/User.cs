using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models{
    public class User
    {
        [Required(ErrorMessage = "Please enter your First name")]
        [MinLength(4, ErrorMessage = "First Name must be at least 4 characters")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Please enter your Last name")]
        [MinLength(4, ErrorMessage = "Last Name must be at least 4 characters")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please your Age")]
        [Range(15,120,ErrorMessage = "Enter a valid age between 15-120")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Please your Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address ex: name@address.com")]
        public string Email{ get; set; }
        
        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public string Password { get; set; }
        
    }
}