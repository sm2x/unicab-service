using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnicabAdminCore.Models;
using UnicabAdminCore.Services;

namespace UnicabAdminCore.Pages.PassengerMgmt
{
    public class ReviewPassengerApplicantModel : PageModel
    {
        private IPassengerManagementService passengerManagementService;
        public PassengerApplicant passengerApplicant;

        public ReviewPassengerApplicantModel(IPassengerManagementService service)
        {
            passengerManagementService = service;
        }

        public async Task OnGetAsync(int id)
        {
            passengerApplicant = await passengerManagementService.GetPassengerApplicant(id);
        }
    }
}