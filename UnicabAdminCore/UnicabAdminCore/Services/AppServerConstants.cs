using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnicabAdminCore.Services
{
    public static class AppServerConstants
    {
        public static string AppServerUrl = "http://10.207.202.119";
        public static int AppServerPort = 53940;

        public static string DriverApplicantsUrl = AppServerUrl + ":" + AppServerPort + "/api/DriverApplicants/{0}";
        public static string PassengerApplicantsUrl = AppServerUrl + ":" + AppServerPort + "/api/PassengerApplicants/{0}";
    }
}
