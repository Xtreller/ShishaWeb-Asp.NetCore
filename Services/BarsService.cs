using Asp.net_Core_Project.Data;
using Asp.net_Core_Project.Models;
using System.Threading.Tasks;
using System.Linq;
using System;
using ShishaWeb.Models.Models;
using Asp.net_Core_Project.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Core_Project.Services
{
    public class BarsService : IBarsService
    {
        private readonly ApplicationDbContext dbContext;

        public BarsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Bar> Create(string userId, string name, string town, string address, string ImageUrl)
        {
            var bar = new Bar
            {
                UserId = userId,
                Name = name,
                Town = town,
                Address = address,
                ImageUrl = ImageUrl
            };

            await this.dbContext.Bars.AddAsync(bar);
            await this.dbContext.SaveChangesAsync();

            return bar;
        }

        public async Task<BarDetailsViewModel> GetByIdAsync(int? Id)
        {
            if (Id == null)
            {
                throw new System.Exception("Id is null");
            }

            var bar = await this.dbContext.Bars.FirstOrDefaultAsync(b => b.Id == Id);


            var barDetails = new BarDetailsViewModel
            {
                Id = bar.Id,
                Name = bar.Name,
                ImageUrl = bar.ImageUrl,
                Address = bar.Address,
                Town = bar.Town,
                Owner = bar.User,
                OwnerId = bar.UserId,
                Comments = bar.Comments,
                Likes = bar.Likes,
                Dislikes = bar.Dislikes,
            };
            return  barDetails;
        }    
        public async Task<Reservation> ReservePlaces(int Id, string firstName, string lastName, int phoneNumber, int clientsCount, DateTime ForWhen)
        {
            var bar =  await this.dbContext.Bars.Where(b => b.Id == Id).FirstOrDefaultAsync();
            if (bar==null)
            {
                throw new Exception($"{bar.Id}");
            }
          
            var reservation = new Reservation
            {
                BarId = bar.Id,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                ClientsCount = clientsCount,
                ForWhen = ForWhen
            };


            await this.dbContext.Reservations.AddAsync(reservation);
            await this.dbContext.SaveChangesAsync();

            return reservation;

        }

        
    }
}
