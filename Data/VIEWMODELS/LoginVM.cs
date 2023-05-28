﻿using System.ComponentModel.DataAnnotations;

namespace S_TCHAD.Data.VIEWMODELS
{
    public class LoginVM
    {
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "مطلوب عنوان البريد الإلكتروني")]
        public string? EmialAddress { get; set; }
        [Required(ErrorMessage = "كلمة المرور مطلوبة")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
