using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnicabAdminCore.Models;
using UnicabAdminCore.Services;

namespace UnicabAdminCore.Pages.DriverMgmt
{
    public class ReviewDriverApplicantModel : PageModel
    {
        private IDriverManagementService driverManagementService;
        public DriverApplicant driverApplicant;

        public ReviewDriverApplicantModel(IDriverManagementService service)
        {
            driverManagementService = service;
        }

        public async Task OnGetAsync(int id)
        {
            driverApplicant = await driverManagementService.GetDriverApplicant(id);
        }
    }
}