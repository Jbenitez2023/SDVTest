using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SDVTest.Migrations
{
    /// <inheritdoc />
    public partial class ModelsUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MgBoost",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StrBoost",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaxVelocity",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "capacity",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vehicleType",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DefBoost",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HPBoost",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpeedBoost",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StrBoost",
                table: "Professions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Element",
                table: "Materias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Def",
                table: "Enemies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElementalWeakness",
                table: "Enemies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Enemies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Str",
                table: "Enemies",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Element" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Element" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Materias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Element" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DefBoost", "HPBoost", "SpeedBoost", "StrBoost" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Professions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DefBoost", "HPBoost", "SpeedBoost", "StrBoost" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxVelocity", "capacity", "color", "vehicleType" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MgBoost", "StrBoost" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MgBoost",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "StrBoost",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "MaxVelocity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "capacity",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "color",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "vehicleType",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "DefBoost",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "HPBoost",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "SpeedBoost",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "StrBoost",
                table: "Professions");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Element",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "Def",
                table: "Enemies");

            migrationBuilder.DropColumn(
                name: "ElementalWeakness",
                table: "Enemies");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Enemies");

            migrationBuilder.DropColumn(
                name: "Str",
                table: "Enemies");
        }
    }
}
