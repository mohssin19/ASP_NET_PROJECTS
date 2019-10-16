using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ASP_NET_Registration_Login.Models
{
    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; } //added in as not in orginal model
                                                    // this data wont save in DB

    }

    public class UserMetadata
    {
        [Display(Name ="First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name Required")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID Required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        public string DateOfBirth { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Passoword is required")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Minimum 8 charecters required")]
        public string Password { get; set; }

        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password and password don't match")]
        public string ConfirmPassword { get; set; }
    }
}