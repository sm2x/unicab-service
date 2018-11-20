using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnicabAdminCore;

namespace UnicabAdminCore.Services
{
    public class DriverManagementService : IDriverManagementService
    {
        public Task GetDriverApplicantsList()
        {
            throw new NotImplementedException();
        }

        public Task ViewDriverApplicant(int driverApplicantId)
        {
            throw new NotImplementedException();
        }

        public Task ApproveDriverApplicant(int driverApplicantId)
        {
            throw new NotImplementedException();
        }

        public Task RejectDriverApplicant(int driverApplicantId)
        {
            throw new NotImplementedException();
        }

        public Task GetApprovedDriversList()
        {
            throw new NotImplementedException();
        }

        public Task ViewDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task SetInactiveDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task SetActiveDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task GetBlacklistedDriversList()
        {
            throw new NotImplementedException();
        }

        public Task ViewBlacklistedDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task BlacklistDriver(int driverId)
        {
            throw new NotImplementedException();
        }

        public Task UnblacklistDriver(int driverId)
        {
            throw new NotImplementedException();
        }
    }
}