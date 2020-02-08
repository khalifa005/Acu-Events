﻿using System.ComponentModel.DataAnnotations;

namespace GigHub.Core.ViewModel
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}