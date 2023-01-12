using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KyhProject1.Migrations
{
    public partial class Newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RectanglePerimeters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameOfShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side1 = table.Column<double>(type: "float", nullable: false),
                    Side2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RectanglePerimeters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RectanglePerimeters");
        }
    }
}
