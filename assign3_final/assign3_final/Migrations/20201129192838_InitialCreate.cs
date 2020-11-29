using Microsoft.EntityFrameworkCore.Migrations;

namespace assign3_final.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adult",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    jobTitle = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    firstName = table.Column<string>(type: "TEXT", nullable: true),
                    lastName = table.Column<string>(type: "TEXT", nullable: true),
                    hairColor = table.Column<string>(type: "TEXT", nullable: true),
                    eyeColor = table.Column<string>(type: "TEXT", nullable: true),
                    age = table.Column<int>(type: "INTEGER", nullable: false),
                    weight = table.Column<float>(type: "REAL", nullable: false),
                    height = table.Column<int>(type: "INTEGER", nullable: false),
                    sex = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adult", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adult");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
