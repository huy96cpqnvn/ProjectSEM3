using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NGO.Models.ViewModel
{
    public class RegisterViewModel
    {
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
            [Required]
            [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            public DateTime BirthDay { get; set; }
            public int PhoneNumber { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "ConfirmPassword")]
            [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
            public string ConfirmPassword { get; set; }

        }
    }
