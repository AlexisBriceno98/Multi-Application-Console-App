using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KyhProject1.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    num1 = table.Column<double>(type: "float", nullable: false),
                    num2 = table.Column<double>(type: "float", nullable: false),
                    Result = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RPSGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerChoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wins = table.Column<double>(type: "float", nullable: false),
                    Losses = table.Column<double>(type: "float", nullable: false),
                    Rounds = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPSGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfShape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Side1 = table.Column<double>(type: "float", nullable: false),
                    Side2 = table.Column<double>(type: "float", nullable: false),
                    Side3 = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Area = table.Column<double>(type: "float", nullable: false),
                    Perimeter = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculators");

            migrationBuilder.DropTable(
                name: "RPSGames");

            migrationBuilder.DropTable(
                name: "Shapes");
        }
    }
}
