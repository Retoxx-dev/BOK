using Microsoft.EntityFrameworkCore.Migrations;

namespace BOK.Data.Migrations
{
    public partial class orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_EditUser_EditUserId1",
                schema: "Identity",
                table: "Order");

            migrationBuilder.DropTable(
                name: "EditUser",
                schema: "Identity");

            migrationBuilder.DropIndex(
                name: "IX_Order_EditUserId1",
                schema: "Identity",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EditUserId",
                schema: "Identity",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EditUserId1",
                schema: "Identity",
                table: "Order");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "Identity",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "Identity",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "Identity",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "Identity",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "EditUserId",
                schema: "Identity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EditUserId1",
                schema: "Identity",
                table: "Order",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EditUser",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PESEL = table.Column<long>(type: "bigint", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_EditUserId1",
                schema: "Identity",
                table: "Order",
                column: "EditUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_EditUser_EditUserId1",
                schema: "Identity",
                table: "Order",
                column: "EditUserId1",
                principalSchema: "Identity",
                principalTable: "EditUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
