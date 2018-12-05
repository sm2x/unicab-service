using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UCAppServer.Contexts;

namespace UCAppServer.Models
{
    public static class ApplicantsSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicantsContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicantsContext>>()))
            {
                if (context.DriverApplicants.Any() && context.PassengerApplicants.Any())
                {
                    return; // DB has been seeded
                }

                if (!context.DriverApplicants.Any())
                {
                    context.DriverApplicants.AddRange(

                        new DriverApplicant
                        {
                            EmailAddress = "nkhlester.ucom14@student.usm.my",
                            MatricsNo = "124373",
                            FirstName = "Lester",
                            LastName = "Ng",
                            Password = "qwertyuiop",
                            CarPlateNo = "BFE9720",
                            CarRoadTaxDueDate = new DateTime(2019, 3, 30)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "tickwei@student.usm.my",
                            MatricsNo = "125678",
                            FirstName = "Jason",
                            LastName = "Heng",
                            Password = "qwertyuiop",
                            CarPlateNo = "PET1234",
                            CarRoadTaxDueDate = new DateTime(2019, 7, 31)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "pjqiang@student.usm.my",
                            MatricsNo = "124324",
                            FirstName = "Henry",
                            LastName = "Pang",
                            Password = "qwertyuiop",
                            CarPlateNo = "QTH2234",
                            CarRoadTaxDueDate = new DateTime(2019, 6, 14)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "samsonchan@student.usm.my",
                            MatricsNo = "123073",
                            FirstName = "Samson",
                            LastName = "Chan",
                            Password = "qwertyuiop",
                            CarPlateNo = "CDE9720",
                            CarRoadTaxDueDate = new DateTime(2019, 3, 21)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "ivankong.uman13@student.usm.my",
                            MatricsNo = "123998",
                            FirstName = "Ivan",
                            LastName = "Kong",
                            Password = "qwertyuiop",
                            CarPlateNo = "PDG6578",
                            CarRoadTaxDueDate = new DateTime(2019, 2, 21)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "mshahrul.ucom14@student.usm.my",
                            MatricsNo = "124567",
                            FirstName = "Shahrul",
                            LastName = "Ibrahim",
                            Password = "qwertyuiop",
                            CarPlateNo = "JDT1234",
                            CarRoadTaxDueDate = new DateTime(2019, 8, 3)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "sitisalehah@student.usm.my",
                            MatricsNo = "125567",
                            FirstName = "Siti Salehah",
                            LastName = "Karuni",
                            Password = "qwertyuiop",
                            CarPlateNo = "DFG5434",
                            CarRoadTaxDueDate = new DateTime(2019, 10, 30)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "wanhammad@student.usm.my",
                            MatricsNo = "PCOM100423/2",
                            FirstName = "Wan Hammad",
                            LastName = "Khalid",
                            Password = "qwertyuiop",
                            CarPlateNo = "WDE1223",
                            CarRoadTaxDueDate = new DateTime(2019, 4, 30)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "danialshahrudin@student.usm.my",
                            MatricsNo = "126765",
                            FirstName = "Danial Shahrudin",
                            LastName = "Hamid",
                            Password = "qwertyuiop",
                            CarPlateNo = "MDT6543",
                            CarRoadTaxDueDate = new DateTime(2019, 3, 12)
                        },

                        new DriverApplicant
                        {
                            EmailAddress = "nithiyabalan@student.usm.my",
                            MatricsNo = "124890",
                            FirstName = "Nithiya Balan",
                            LastName = "Karuppiah",
                            Password = "qwertyuiop",
                            CarPlateNo = "ACV3123",
                            CarRoadTaxDueDate = new DateTime(2019, 5, 20)
                        }

                    );
                    context.SaveChanges();
                }

                if (!context.PassengerApplicants.Any())
                {
                    context.PassengerApplicants.AddRange(

                        new PassengerApplicant
                        {
                            EmailAddress = "danialshahrudin@student.usm.my",
                            MatricsNo = "126765",
                            FirstName = "Danial Shahrudin",
                            LastName = "Hamid",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "nkhlester.ucom14@student.usm.my",
                            MatricsNo = "124373",
                            FirstName = "Lester",
                            LastName = "Ng",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "sitisalehah@student.usm.my",
                            MatricsNo = "125567",
                            FirstName = "Siti Salehah",
                            LastName = "Karuni",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "wanhammad@student.usm.my",
                            MatricsNo = "PCOM100423/2",
                            FirstName = "Wan Hammad",
                            LastName = "Khalid",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "tickwei@student.usm.my",
                            MatricsNo = "125678",
                            FirstName = "Jason",
                            LastName = "Heng",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "pjqiang@student.usm.my",
                            MatricsNo = "124324",
                            FirstName = "Henry",
                            LastName = "Pang",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "samsonchan@student.usm.my",
                            MatricsNo = "123073",
                            FirstName = "Samson",
                            LastName = "Chan",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "ivankong.uman13@student.usm.my",
                            MatricsNo = "123998",
                            FirstName = "Ivan",
                            LastName = "Kong",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "mshahrul.ucom14@student.usm.my",
                            MatricsNo = "124567",
                            FirstName = "Shahrul",
                            LastName = "Ibrahim",
                            Password = "qwertyuiop"
                        },

                        new PassengerApplicant
                        {
                            EmailAddress = "nithiyabalan@student.usm.my",
                            MatricsNo = "124890",
                            FirstName = "Nithiya Balan",
                            LastName = "Karuppiah",
                            Password = "qwertyuiop"
                        }

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
