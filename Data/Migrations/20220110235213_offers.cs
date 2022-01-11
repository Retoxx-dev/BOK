using Microsoft.EntityFrameworkCore.Migrations;

namespace BOK.Data.Migrations
{
    public partial class offers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offer",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    OpticalFibre = table.Column<bool>(type: "bit", nullable: false),
                    MonthlyCost = table.Column<int>(type: "int", nullable: false),
                    CommitmentPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offer",
                schema: "Identity");
        }
    }
}
