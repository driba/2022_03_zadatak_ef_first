using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class DorianMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 45.815399m, 15.966568m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 45.328979m, 14.457664m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 43.508133m, 16.440193m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 34.052235m, -118.243683m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 40.73061m, -73.740135m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 0m, 0m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 0m, 0m });
        }
    }
}
