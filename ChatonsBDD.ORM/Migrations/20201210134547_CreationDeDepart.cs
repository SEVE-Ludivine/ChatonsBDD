using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatonsBDD.ORM.Migrations
{
    public partial class CreationDeDepart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chatons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DateDeNaissance = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Sterilise = table.Column<bool>(type: "INTEGER", nullable: true),
                    EstUneFemelle = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chatons", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chatons");
        }
    }
}
