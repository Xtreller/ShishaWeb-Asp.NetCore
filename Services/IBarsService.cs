using Asp.net_Core_Project.Models;
using Asp.net_Core_Project.ViewModels;
using Microsoft.AspNetCore.Identity;
using ShishaWeb.Models.Models;
using System;
using System.Threading.Tasks;

namespace Asp.net_Core_Project.Services
{
    public interface IBarsService
    {
        Task<Bar> Create(string userId,string name, string town, string address, string ImageUrl);
        Task<Reservation> ReservePlaces(int barId, string firstName ,string lastName ,int phoneNumber, int clientsCount,DateTime reservedFor);
        Task<BarDetailsViewModel> GetByIdAsync(int? id);
    }
}
