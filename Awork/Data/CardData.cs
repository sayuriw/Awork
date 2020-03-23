using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Awork.Data
{
    public class CardData
    {
        [Required]
        [RegularExpression("^[0-9]{15}(?:[0-9]{1})?$", ErrorMessage ="Please enter a valid Creditcard Number")]
        public string CardNumber { get; set; }
        
        [Required]
        public string CardName { get; set; }

        [Required]
        [Range(01,12, ErrorMessage = "Please select Expire Month")]
        public int MonthValidity { get; set; }

        [Required]
        [Range(2020, 2030, ErrorMessage = "Please select Expire Year")]
        public int YearValidity { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}(?:[0-9]{1})?$", ErrorMessage = "Please enter a valid CVV Number")]
        public string CvvNumber { get; set; }
        
        
    }
}
