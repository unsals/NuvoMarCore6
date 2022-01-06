using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class user_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NuvoUsers",
                columns: table => new
                {
                    UsrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsrUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsrSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsrEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsrPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsrStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NuvoUsers", x => x.UsrId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NuvoUsers");
        }
    }
}
