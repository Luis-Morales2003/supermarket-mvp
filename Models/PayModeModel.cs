﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName ("Pay Mode Id ")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage ="Pay mode name is required")]
        [StringLength (50, MinimumLength = 3,ErrorMessage ="Pay mde name must be between 3 and 50 characteres")]
        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage ="Pay mode observation is requeride")]
        [StringLength(200, MinimumLength = 3,ErrorMessage = "Pay mode observation must be between 3 and 50 characteres")]
        public string Observation { get; set; }
    }
}
