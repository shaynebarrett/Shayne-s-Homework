﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Homework6.Models
{
    public class BirthdayCardInfo
    {
        
        [Required(ErrorMessage = "Please enter To:")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter From:")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter a message")]
        public string Message { get; set; }
    }
}