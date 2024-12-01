using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDVTest.Migrations
{
    /// <inheritdoc />
    public partial class Ajuste2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Materia_Materias_IdMateria",
                table: "People_Materia");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Materia_Peoples_IdPeople",
                table: "People_Materia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People_Materia",
                table: "People_Materia");

            migrationBuilder.RenameTable(
                name: "People_Materia",
                newName: "peopleMateria");

            migrationBuilder.RenameIndex(
                name: "IX_People_Materia_IdPeople",
                table: "peopleMateria",
                newName: "IX_peopleMateria_IdPeople");

            migrationBuilder.RenameIndex(
                name: "IX_People_Materia_IdMateria",
                table: "peopleMateria",
                newName: "IX_peopleMateria_IdMateria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_peopleMateria",
                table: "peopleMateria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_peopleMateria_Materias_IdMateria",
                table: "peopleMateria",
                column: "IdMateria",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_peopleMateria_Peoples_IdPeople",
                table: "peopleMateria",
                column: "IdPeople",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_peopleMateria_Materias_IdMateria",
                table: "peopleMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_peopleMateria_Peoples_IdPeople",
                table: "peopleMateria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_peopleMateria",
                table: "peopleMateria");

            migrationBuilder.RenameTable(
                name: "peopleMateria",
                newName: "People_Materia");

            migrationBuilder.RenameIndex(
                name: "IX_peopleMateria_IdPeople",
                table: "People_Materia",
                newName: "IX_People_Materia_IdPeople");

            migrationBuilder.RenameIndex(
                name: "IX_peopleMateria_IdMateria",
                table: "People_Materia",
                newName: "IX_People_Materia_IdMateria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People_Materia",
                table: "People_Materia",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Materia_Materias_IdMateria",
                table: "People_Materia",
                column: "IdMateria",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Materia_Peoples_IdPeople",
                table: "People_Materia",
                column: "IdPeople",
                principalTable: "Peoples",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
