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
    public class IndexModel : PageModel
    {
        public List<DriverApplicant> DriverApplicants { get; set; }

        private IDriverManagementService driverManagementService;

        public IndexModel(IDriverManagementService service)
        {
            driverManagementService = service;
        }

        public async Task OnGetAsync()
        {
            DriverApplicants = await driverManagementService.GetDriverApplicantsList();
        }
    }
}