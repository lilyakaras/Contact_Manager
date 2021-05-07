using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "length sould be longer than 2 symbols")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }
        [Display(Name = "Married")]
        public bool IsMarried { get; set; }
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
        [Range(typeof(decimal), "1000", "100000", ErrorMessage = "Valid format is: 00.00")]
        public decimal Salary { get; set; }
    }
}
