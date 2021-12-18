using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VoyageShipId",
                table: "Voyages",
                newName: "ShipId");

            migrationBuilder.RenameColumn(
                name: "VoyagePortId",
                table: "Voyages",
                newName: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Voyages_PortId",
                table: "Voyages",
                column: "PortId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voyages_Ports_PortId",
                table: "Voyages",
                column: "PortId",
                principalTable: "Ports",
                principalColumn: "PortId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyages_Ports_PortId",
                table: "Voyages");

            migrationBuilder.DropIndex(
                name: "IX_Voyages_PortId",
                table: "Voyages");

            migrationBuilder.RenameColumn(
                name: "ShipId",
                table: "Voyages",
                newName: "VoyageShipId");

            migrationBuilder.RenameColumn(
                name: "PortId",
                table: "Voyages",
                newName: "VoyagePortId");
        }
    }
}
