using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ValidationDemo.Models
{
    public class UserDetails
    {
        [Required(ErrorMessage= "Please enter your User Name")]
        [StringLength(15, ErrorMessage ="User Name can not be longer then 15 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please enter your Password")]
        [StringLength(6,MinimumLength =4, ErrorMessage ="Minimum Length is 4 or max 6 characters")]
        [DataType("password")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name ="Confirm password")]
        [Compare(nameof(Password), ErrorMessage ="Passwords don't match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage ="Date of birth is required")]
        [DisplayName("Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="0:d", ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Please enter valid email format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your postal code")]
        [Range(1000,9000,ErrorMessage ="Choose valid range for the postal code")]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "Please enter your Phone number")]
        [DisplayName("Phone Number")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your profile")]
        [DataType(DataType.MultilineText)]
        public string Profile { get; set; }
        [FileExtensions(Extensions ="png,jpg,jpeg,gif")]
        public string Photo { get; set; }
        [DisplayName("Add some additional comments if needed")]

        public string Comments { get; set; }
    }
}
