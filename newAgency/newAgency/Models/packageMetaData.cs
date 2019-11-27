using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace newAgency.Models
{
    public class packageMetaData
    {
        [MetadataType(typeof(packageMetaData))]
        public partial class package
        {

        }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 250 character")]
        [MinLength(5, ErrorMessage = "doesn't  allowe to enter less than 5 character")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Range(1, Double.MaxValue, ErrorMessage = "Enter number grater than 0")]
        public decimal price { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/]\d{4}$", ErrorMessage = "End Date should be in MM/dd/yyyy format")]
        public DateTime startDate { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [RegularExpression(@"^(0[1-9]|1[012])[/](0[1-9]|[12][0-9]|3[01])[/]\d{4}$", ErrorMessage = "End Date should be in MM/dd/yyyy format")]
        public DateTime endDate { get; set; }
        public bool available { get; set; }
    }
}