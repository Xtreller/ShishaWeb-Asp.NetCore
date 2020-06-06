using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShishaWeb.ViewModels
{
    public class ReservePlacesInputModel
    {

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [DisplayName("Phone Number:")]
        public int PhoneNumber { get; set; }
        [Required]
        [Range(1, 10)]
        [DisplayName("Count Of Clients:")]

        public int ClientsCount { get; set; }
        [Required]
        [DisplayName("For When:")]
        public DateTime ForWhen { get; set; }

    }
}
