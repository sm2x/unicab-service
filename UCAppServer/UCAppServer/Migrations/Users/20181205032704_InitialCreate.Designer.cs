﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UCAppServer.Contexts;

namespace UCAppServer.Migrations.Users
{
    [DbContext(typeof(UsersContext))]
    [Migration("20181205032704_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UCAppServer.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDateTime");

                    b.Property<DateTime>("BlacklistedDateTime");

                    b.Property<string>("BlacklistedReason");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<bool>("IsBlacklisted");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("LastName");

                    b.Property<byte[]>("MatricsCardPhoto");

                    b.Property<string>("MatricsNo");

                    b.Property<string>("PhoneNo");

                    b.Property<DateTime>("VerifiedDateTime");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("UCAppServer.Models.Driver", b =>
                {
                    b.HasBaseType("UCAppServer.Models.User");

                    b.Property<string>("CarColour");

                    b.Property<byte[]>("CarInsuranceGrantPhoto");

                    b.Property<string>("CarMake");

                    b.Property<string>("CarMakeYear");

                    b.Property<string>("CarModel");

                    b.Property<string>("CarPlateNo");

                    b.Property<DateTime>("CarRoadTaxDueDate");

                    b.Property<string>("DriverPassword");

                    b.Property<byte[]>("DrivingLicensePhoto");

                    b.ToTable("Driver");

                    b.HasDiscriminator().HasValue("Driver");
                });

            modelBuilder.Entity("UCAppServer.Models.Passenger", b =>
                {
                    b.HasBaseType("UCAppServer.Models.User");

                    b.Property<string>("PassengerPassword");

                    b.ToTable("Passenger");

                    b.HasDiscriminator().HasValue("Passenger");
                });
#pragma warning restore 612, 618
        }
    }
}