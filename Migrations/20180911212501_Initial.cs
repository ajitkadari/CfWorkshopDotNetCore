using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CfWorkshopDotNetCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Note",
                columns: new[] { "ID", "Created", "Text" },
                values: new object[] { 1, new DateTime(2018, 9, 11, 16, 25, 1, 128, DateTimeKind.Local), "Note #1" });

            migrationBuilder.InsertData(
                table: "Note",
                columns: new[] { "ID", "Created", "Text" },
                values: new object[] { 2, new DateTime(2018, 9, 11, 16, 25, 1, 161, DateTimeKind.Local), "Note #2" });

            migrationBuilder.InsertData(
                table: "Note",
                columns: new[] { "ID", "Created", "Text" },
                values: new object[] { 3, new DateTime(2018, 9, 11, 16, 25, 1, 161, DateTimeKind.Local), "Note #3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");
        }
    }
}
