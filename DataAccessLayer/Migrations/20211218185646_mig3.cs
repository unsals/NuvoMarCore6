using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyages",
                column: "ShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voyages_Ships_ShipId",
                table: "Voyages",
                column: "ShipId",
                principalTable: "Ships",
                principalColumn: "ShipId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voyages_Ships_ShipId",
                table: "Voyages");

            migrationBuilder.DropIndex(
                name: "IX_Voyages_ShipId",
                table: "Voyages");
        }
    }
}
