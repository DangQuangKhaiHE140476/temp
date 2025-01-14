﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QLHSC07.Model.IdentityAccess
{
    public class RegisterDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} phải dài ít nhất {5} ký tự.", MinimumLength = 5)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "{0} phải dài ít nhất {5} ký tự.", MinimumLength = 5)]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} phải dài ít nhất {2} ký tự.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Mật khẩu và mật khẩu xác nhận không khớp.")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }   
        public bool? Sex { get; set; }
    }
}
