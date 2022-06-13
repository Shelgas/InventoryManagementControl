using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMC.Infrastructure.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Row = table.Column<int>(type: "integer", nullable: false),
                    Column = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paints", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Paints",
                columns: new[] { "Id", "Color", "Column", "Row", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("1c8d768e-4c33-49b2-a136-a49e80bfe372"), "#000000", 1, 2, "Nuln Oil", "Shade" },
                    { new Guid("3f168c6c-b670-4628-bdd2-a87417b6934b"), "#f0f1ce", 1, 4, "Screaming Skull", "Layer" },
                    { new Guid("4418106b-2a7a-4bbd-a6b7-0dc962e56467"), "#33312D", 1, 3, "Dryad Bark", "Base" },
                    { new Guid("b5400f35-e664-4c09-b4e5-ba7365282588"), "#63b521", 1, 1, "Warboss Green", "Layer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paints_Id",
                table: "Paints",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paints");
        }
    }
}
