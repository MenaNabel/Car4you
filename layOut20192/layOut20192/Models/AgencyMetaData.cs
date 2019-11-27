﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace layOut20192.Models
{ 

    [MetadataType(typeof(AgencyMetaData))]
    public partial class setting_agency
    {

    }
public class AgencyMetaData
{
    [Required(ErrorMessage = "This field is required")]
    [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 250 character")]
    [MinLength(5, ErrorMessage = "doesn't allowe to enter less than 5 character")]
    [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
    public string AgencyName { get; set; }
    [Required(ErrorMessage = "This field is required")]
    [MaxLength(250, ErrorMessage = "doesn't allowe to enter more than 250 character")]
    [MinLength(250, ErrorMessage = "doesn't allowe to enter less than 5 character")]
    [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
    public string adminName { get; set; }
    [Required(ErrorMessage = "This field is required")]
    [MaxLength(14, ErrorMessage = "doesn't allowe to enter more than 14 number")]
    [MinLength(14, ErrorMessage = "doesn't allowe to enter less than 14 character")]
    [RegularExpression("[^0-9]", ErrorMessage = "Enter numerric only")]
    public string NationalID { get; set; }
    [EmailAddress(ErrorMessage = "Enter correct email @example.com")]
    [RegularExpression(@"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$", ErrorMessage = "Invalid email")]
    public string email { get; set; }
    [Required(ErrorMessage = "This field is required")]
    public string password { get; set; }
    [Required(ErrorMessage = "confirm your password")]
    public string confirmPassword { get; set; }
}
}
