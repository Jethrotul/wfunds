using Microsoft.EntityFrameworkCore.Migrations;

namespace Funds.Migrations
{
    public partial class InitialCreate : Migration
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
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    Country = table.Column<string>(nullable: true),
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
                value: "Activo");

            migrationBuilder.InsertData(
                table: "FundTypes",
                column: "Name",
                value: "Pasivo");

            migrationBuilder.InsertData(
                table: "FundTypes",
                column: "Name",
                value: "Híbrido");

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "FundId", "Country", "FundTypeName", "Name", "Price" },
                values: new object[] { 1, "España", "Activo", "True value", 850f });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "FundId", "Country", "FundTypeName", "Name", "Price" },
                values: new object[] { 2, "España", "Activo", "Cobas", 1020f });

            migrationBuilder.InsertData(
                table: "Funds",
                columns: new[] { "FundId", "Country", "FundTypeName", "Name", "Price" },
                values: new object[] { 3, "EE.UU", "Pasivo", "Índice SP500", 3500f });

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
