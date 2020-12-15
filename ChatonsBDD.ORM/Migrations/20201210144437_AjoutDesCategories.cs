using Microsoft.EntityFrameworkCore.Migrations;

namespace ChatonsBDD.ORM.Migrations
{
    public partial class AjoutDesCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieId",
                table: "Chatons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Libelle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chatons_CategorieId",
                table: "Chatons",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chatons_Categories_CategorieId",
                table: "Chatons",
                column: "CategorieId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chatons_Categories_CategorieId",
                table: "Chatons");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Chatons_CategorieId",
                table: "Chatons");

            migrationBuilder.DropColumn(
                name: "CategorieId",
                table: "Chatons");
        }
    }
}
