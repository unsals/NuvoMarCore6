using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class datetimechanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageDepartureDate",
                table: "Voyages",
                type: "Datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageArrivalDate",
                table: "Voyages",
                type: "Datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageDepartureDate",
                table: "Voyages",
                type: "Datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageArrivalDate",
                table: "Voyages",
                type: "Datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime",
                oldNullable: true);
        }
    }
}
