using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EvaluacionTecnica.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyType",
                table: "CurrencyType");

            migrationBuilder.RenameTable(
                name: "CurrencyType",
                newName: "CurrencyTypes");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyType_Description",
                table: "CurrencyTypes",
                newName: "IX_CurrencyTypes_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyTypes",
                table: "CurrencyTypes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Identidad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Code",
                table: "Customers",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_GenderId",
                table: "Customers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Identidad",
                table: "Customers",
                column: "Identidad",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurrencyTypes",
                table: "CurrencyTypes");

            migrationBuilder.RenameTable(
                name: "CurrencyTypes",
                newName: "CurrencyType");

            migrationBuilder.RenameIndex(
                name: "IX_CurrencyTypes_Description",
                table: "CurrencyType",
                newName: "IX_CurrencyType_Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurrencyType",
                table: "CurrencyType",
                column: "Id");
        }
    }
}
