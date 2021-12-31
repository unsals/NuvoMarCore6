using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ports",
                columns: table => new
                {
                    PortId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PortUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PortDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipStatus = table.Column<bool>(type: "bit", nullable: true),
                    ShipCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    ShipId = table.Column<int>(type: "int", nullable: true),
                    PortId = table.Column<int>(type: "int", nullable: true),
                    VoyageArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VoyageDepartureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VoyageCreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VoyageUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VoyageDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voyages", x => x.VoyageId);
                    table.ForeignKey(
                        name: "FK_Voyages_Ports_PortId",
                        column: x => x.PortId,
                        principalTable: "Ports",
                        principalColumn: "PortId");
                    table.ForeignKey(
                        name: "FK_Voyages_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "ShipId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_PortId",
                table: "Voyages",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyages",
                column: "ShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voyages");

            migrationBuilder.DropTable(
                name: "Ports");

            migrationBuilder.DropTable(
                name: "Ships");
        }
    }
}
