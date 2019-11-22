using Microsoft.EntityFrameworkCore.Migrations;

namespace Funds.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FundTypes",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundTypes", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    FundId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Isin = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    AReturn = table.Column<double>(nullable: false),
                    A5Return = table.Column<double>(nullable: false),
                    Manager = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    FundTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.FundId);
                    table.ForeignKey(
                        name: "FK_Funds_FundTypes_FundTypeName",
                        column: x => x.FundTypeName,
                        principalTable: "FundTypes",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "FundTypes",
                column: "Name",
                value: "Active");

            migrationBuilder.InsertData(
                table: "FundTypes",
                column: "Name",
                value: "Passive");

            migrationBuilder.InsertData(
                table: "FundTypes",
                column: "Name",
                value: "Hybrid");

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "FundId", "A5Return", "AReturn", "Category", "FundTypeName", "Isin", "Manager", "Name", "Price" },
                values: new object[] { 1, 11.74, 14.18, "Renta variable", null, "ES0180792006", "Renta 4 Gestora", "True value FI", 16.309999999999999 });

            migrationBuilder.CreateIndex(
                name: "IX_Funds_FundTypeName",
                table: "Funds",
                column: "FundTypeName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "FundTypes");
        }
    }
}
