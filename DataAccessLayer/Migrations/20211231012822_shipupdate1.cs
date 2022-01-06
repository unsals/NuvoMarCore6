using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class shipupdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipCallSign",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipDWT",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipDraft",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipFlag",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipGRT",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipIMO",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipLoa",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipMMSI",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipNRT",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipRegistry",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipCallSign",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipDWT",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipDraft",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipFlag",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipGRT",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipIMO",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipLoa",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipMMSI",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipNRT",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "ShipRegistry",
                table: "Ships");
        }
    }
}
