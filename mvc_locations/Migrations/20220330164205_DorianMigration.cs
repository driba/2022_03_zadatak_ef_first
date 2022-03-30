using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_locations.Migrations
{
    public partial class DorianMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 1, "1", "USA", "United States" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "country_code", "country_name", "country_name_eng" },
                values: new object[] { 2, "385", "Hrvatska", "Croatia" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "id", "city_name", "country_id", "latitude", "longitude" },
                values: new object[,]
                {
                    { 1, "Washington DC", 1, 38.897957m, -77.036560m },
                    { 2, "New York", 1, 40.73061m, -73.740135m },
                    { 3, "Zagreb", 2, 40.73061m, -73.740135m },
                    { 4, "Rijeka", 2, 0m, 0m },
                    { 5, "Split", 2, 0m, 0m },
                    { 6, "Los Angeles", 1, 0m, 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
