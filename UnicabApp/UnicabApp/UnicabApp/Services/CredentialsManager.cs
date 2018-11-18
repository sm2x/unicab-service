﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UnicabApp.Models;

namespace UnicabApp.Services
{
    public class CredentialsManager
    {
        ICredentialsService credentialsService;

        public CredentialsManager(ICredentialsService service)
        {
            credentialsService = service;
        }

        public Task<HttpStatusCode> TryDriverSignUp(DriverApplicant applicant)
        {
            return credentialsService.TryDriverSignUp(applicant);
        }

        public Task<HttpStatusCode> TryPassengerSignUp(PassengerApplicant applicant)
        {
            return credentialsService.TryPassengerSignUp(applicant);
        }
    }
}
