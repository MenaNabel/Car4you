using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace layOut20192.Models
{
    /*[MetadataType(typeof(carMetadata))]
    public partial class car
    {

    }*/
    public class carMetadata
    {
        /*[Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 255 character")]
        [MinLength(3, ErrorMessage = "doesn't allowe to enter less than 3 character")]
        //[CheckCarNumberNotfoud]
        public string num { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Range(1, Double.MaxValue, ErrorMessage = "Enter number grater than 0")]
        public decimal price { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 255 character")]
        [MinLength(3, ErrorMessage = "doesn't allowe to enter less than 3 character")]
        [RegularExpression(@"w\{3,250}", ErrorMessage = "Only Alphabets allowed.")]
        //[RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        public string type_car { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Range(3, 10, ErrorMessage = "Enter number between 3 and 10")]
        [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]

        public int num_seats { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 255 character")]
        [MinLength(3, ErrorMessage = "doesn't allowe to enter less than 3 character")]
        [RegularExpression(@"w\{3,250}", ErrorMessage = "Only Alphabets allowed.")]
        public string col { get; set; }
        public string pick { get; set; }
        public bool available { get; set; }
        public Nullable<bool> air_conditioning { get; set; }*/

    }
}