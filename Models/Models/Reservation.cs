using System;
using Asp.net_Core_Project.Models;
using Asp.net_Core_Project.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShishaWeb.Models.Models
{
    public class Reservation : BaseModel<int>
    {
        public int BarId { get; set; }
        public Bar Bar { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]        
        public int ClientsCount { get; set; }
        [Required]
        public DateTime ForWhen { get; set; }
    }
}
