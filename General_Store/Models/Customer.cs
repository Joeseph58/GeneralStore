using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace General_Store.Models
{
    public class Customer
    {
        //CustomerID | FirstName | LastName |  Contact Info | IsPleasant

        [Key]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Required]

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        
        public string ContactInfo { get; set; }
        [Required]
        [Display(Name = "Is very Pleasant")]

        public bool IsPleasant { get; set; }
    }
}