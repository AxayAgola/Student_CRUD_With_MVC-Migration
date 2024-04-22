using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Application_Migration.Migrations
{
    public partial class adddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REGISTRATION",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Studentname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studentbranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Studentroll = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGISTRATION", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REGISTRATION");
        }
    }
}
