﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnicabAdminCore.Models;
using UnicabAdminCore.Services;

namespace UnicabAdminCore.Pages.PassengerMgmt
{
    public class IndexModel : PageModel
    {
        public List<PassengerApplicant> PassengerApplicants { get; set; }
        public List<Passenger> Passengers { get; set; }

        private IPassengerManagementService passengerManagementService;

        public IndexModel(IPassengerManagementService service)
        {
            passengerManagementService = service;
        }

        public async Task OnGetAsync()
        {
            PassengerApplicants = await passengerManagementService.GetPassengerApplicantsList();

            Passengers = await passengerManagementService.GetApprovedPassengersList();
        }
    }
}