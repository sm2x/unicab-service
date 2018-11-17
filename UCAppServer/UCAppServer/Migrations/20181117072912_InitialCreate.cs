using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UCAppServer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DriverApplicants",
                columns: table => new
                {
                    DriverApplicantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: true),
                    MatricsNo = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MatricsCardPhoto = table.Column<byte[]>(nullable: true),
                    DrivingLicensePhoto = table.Column<byte[]>(nullable: true),
                    CarPlateNo = table.Column<string>(nullable: true),
                    RoadTaxDueDate = table.Column<DateTime>(nullable: false),
                    CarInsuranceGrantPhoto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverApplicants", x => x.DriverApplicantId);
                });

            migrationBuilder.CreateTable(
                name: "PassengerApplicants",
                columns: table => new
                {
                    PassengerApplicantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmailAddress = table.Column<string>(nullable: true),
                    MatricsNo = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MatricsCardPhoto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerApplicants", x => x.PassengerApplicantId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverApplicants");

            migrationBuilder.DropTable(
                name: "PassengerApplicants");
        }
    }
}
