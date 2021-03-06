﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCAppServer.Contexts;

namespace UCAppServer.Migrations.Applicants
{
    [DbContext(typeof(ApplicantsContext))]
    [Migration("20181205032642_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UCAppServer.Models.DriverApplicant", b =>
                {
                    b.Property<int>("DriverApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplicationDateTime");

                    b.Property<string>("CarColour");

                    b.Property<byte[]>("CarInsuranceGrantPhoto");

                    b.Property<string>("CarMake");

                    b.Property<string>("CarMakeYear");

                    b.Property<string>("CarModel");

                    b.Property<string>("CarPlateNo");

                    b.Property<DateTime>("CarRoadTaxDueDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<byte[]>("DrivingLicensePhoto");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<string>("Password");

                    b.HasKey("DriverApplicantId");

                    b.ToTable("DriverApplicants");
                });

            modelBuilder.Entity("UCAppServer.Models.PassengerApplicant", b =>
                {
                    b.Property<int>("PassengerApplicantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApplicationDateTime");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<string>("Password");

                    b.HasKey("PassengerApplicantId");

                    b.ToTable("PassengerApplicants");
                });
#pragma warning restore 612, 618
        }
    }
}
