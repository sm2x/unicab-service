using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using UnicabAdminCore.Models;

namespace UnicabAdminCore.Services
{
    public class DriverManagementService : IDriverManagementService
    {
        private readonly HttpClient client;

        public List<DriverApplicant> DriverApplicantsList { get; private set;}

        public DriverManagementService()
        {
            client = new HttpClient
            {
                MaxResponseContentBufferSize = 256000
            };
        }

        public async Task<List<DriverApplicant>> GetDriverApplicantsList()
        {
            DriverApplicantsList = new List<DriverApplicant>();

            var uri = new Uri(string.Format(AppServerConstants.DriverApplicantsUrl, string.Empty));
            
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    DriverApplicantsList = JsonConvert.DeserializeObject<List<DriverApplicant>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR: {0}", ex.Message);
            }

            return DriverApplicantsList;

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