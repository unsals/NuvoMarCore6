using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    PortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PortDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ports", x => x.PortId);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    ShipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipStatus = table.Column<bool>(type: "bit", nullable: false),
                    ShipCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.ShipId);
                });

            migrationBuilder.CreateTable(
                name: "Voyages",
                columns: table => new
                {
                    VoyageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoyageShipId = table.Column<int>(type: "int", nullable: false),
                    VoyagePortId = table.Column<int>(type: "int", nullable: false),
                    VoyageArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoyageDepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoyageCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoyageUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VoyageDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voyages", x => x.VoyageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Voyages");
        }
    }
}
