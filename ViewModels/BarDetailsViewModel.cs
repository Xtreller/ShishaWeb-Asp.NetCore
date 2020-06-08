using Asp.net_Core_Project.Models;
using Microsoft.AspNetCore.Identity;
using ShishaWeb.Models.Models;
using System.Collections.Generic;


namespace Asp.net_Core_Project.ViewModels
{
    public class BarDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string OwnerId { get; set; }
        public IdentityUser Owner { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public IEnumerable<Reservation> Reservation { get; set; }

    }
}
