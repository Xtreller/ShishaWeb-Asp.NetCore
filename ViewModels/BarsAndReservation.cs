using Asp.net_Core_Project.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShishaWeb.ViewModels
{
    public class BarsAndReservation
    {
        public IEnumerable<BarDetailsViewModel> BarDetails { get; set; }
        public IEnumerable<ReservePlacesInputModel> ReservationInput{ get; set; }
    }
}
