using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Asp.net_Core_Project.Data;
using Microsoft.AspNetCore.Identity;
using Asp.net_Core_Project.Services;
using Asp.net_Core_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using ShishaWeb.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Asp.net_Core_Project.Controllers
{
    public class BarsController : Controller
    {
        private ApplicationDbContext db;
        private readonly IBarsService barsService;
        private readonly UserManager<IdentityUser> userManager;

        public BarsController(IBarsService barsService,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext db)
        {
            this.db = db;
            this.barsService = barsService;
            this.userManager = userManager;
        }
        [Authorize]
        public IActionResult Bars()
        {
            var bars = this.db.Bars.ToList();
            var barModel = new BarsViewModel
            {
                Bars = bars
            };
            return View(barModel);
        }
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddBarInputModel input)
        {
            var user = await this.userManager.GetUserAsync(this.User);          
            await this.barsService.Create(user.Id,input.Name,input.Town, input.Address, input.ImageURL);           
            return RedirectToAction("Bars");
        }
        public async Task<IActionResult> Details(int? Id)
        {
           
            var barDetails = await this.barsService.GetByIdAsync(Id);
           
          
            if (barDetails == null)
            {
                return this.NotFound();
            }
            TempData["barId"] = barDetails.Id;
            

            return this.View(barDetails);
        }

        
        [HttpPost]
        public async Task<IActionResult> ReservePlaces(ReservePlacesInputModel input)
        {
            var BarId = (int)TempData["barId"];
            await this.barsService.ReservePlaces(BarId, input.FirstName, input.LastName, input.PhoneNumber, input.ClientsCount, input.ForWhen);
            return RedirectToAction("Bars");
        }

        //[HttpPost]
        //public IActionResult Delete(int? Id,string OwnerId)
        //{
        //    if()
            
        //}
    }
}