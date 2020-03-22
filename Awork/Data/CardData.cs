using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Awork.Data
{
    public class CardData
    {
        //public int Id { get; set; }
        [Required]
        [Range(1000000000000000, 9999999999999999)]
        private int _CardNumber;

        public string CardNumber
        {
            get
            {
                return _CardNumber.ToString();
            }
            set
            {
                _CardNumber = int.Parse(value);
            }
        }
        

        [Required]
        public string CardName { get; set; }

        [Required]
        [Range(01,12, ErrorMessage = "Please select Expire Month")]
        public int MonthValidity { get; set; }

        [Required]
        [Range(2020, 2030, ErrorMessage = "Please select Expire Year")]
        public int YearValidity { get; set; }

        private int _CvvNumber;

        public string CvvNumber
        {
            get
            {
                return _CvvNumber.ToString();
            }
            set
            {
                _CvvNumber = int.Parse(value);
            }
        }
        
    }
}
