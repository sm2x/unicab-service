using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnicabAdminCore;
using UnicabAdminCore.Models;

namespace UnicabAdminCore.Services
{
    public interface IDriverManagementService
    {
        Task<List<DriverApplicant>> GetDriverApplicantsList();

        Task ViewDriverApplicant(int driverApplicantId);

        Task ApproveDriverApplicant(int driverApplicantId);

        Task RejectDriverApplicant(int driverApplicantId);

        Task GetApprovedDriversList();

        Task ViewDriver(int driverId);

        Task SetInactiveDriver(int driverId);

        Task SetActiveDriver(int driverId);

        Task GetBlacklistedDriversList();

        Task ViewBlacklistedDriver(int driverId);

        Task BlacklistDriver(int driverId);

        Task UnblacklistDriver(int driverId);

    }
}