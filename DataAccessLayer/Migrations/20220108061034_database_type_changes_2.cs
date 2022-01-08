using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class database_type_changes_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageDepartureDate",
                table: "Voyages",
                type: "Datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageArrivalDate",
                table: "Voyages",
                type: "Datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageDepartureDate",
                table: "Voyages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VoyageArrivalDate",
                table: "Voyages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "Datetime",
                oldNullable: true);
        }
    }
}
