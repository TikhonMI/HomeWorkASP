using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RussianLanguage = table.Column<int>(type: "int", nullable: false),
                    Literature = table.Column<int>(type: "int", nullable: false),
                    ForeignLanguage = table.Column<int>(type: "int", nullable: false),
                    Algebra = table.Column<int>(type: "int", nullable: false),
                    Geometry = table.Column<int>(type: "int", nullable: false),
                    ComputerScience = table.Column<int>(type: "int", nullable: false),
                    Story = table.Column<int>(type: "int", nullable: false),
                    SocialScience = table.Column<int>(type: "int", nullable: false),
                    Economy = table.Column<int>(type: "int", nullable: false),
                    Geography = table.Column<int>(type: "int", nullable: false),
                    Physics = table.Column<int>(type: "int", nullable: false),
                    Astronomy = table.Column<int>(type: "int", nullable: false),
                    Chemistry = table.Column<int>(type: "int", nullable: false),
                    Biology = table.Column<int>(type: "int", nullable: false),
                    LifeSafetyFundamentals = table.Column<int>(type: "int", nullable: false),
                    PhysicalCulture = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
