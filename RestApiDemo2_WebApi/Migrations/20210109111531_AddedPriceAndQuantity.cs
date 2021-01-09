using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiDemo_WebApi.Migrations
{
    public partial class AddedPriceAndQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cookwares",
                columns: new[] { "Id", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Plate", 4.50m, 40 },
                    { 2, "Fork", 2.90m, 80 },
                    { 3, "Spoon", 1.90m, 60 }
                });

            migrationBuilder.InsertData(
                table: "Fruits",
                columns: new[] { "Id", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Apple", 0.50m, 10 },
                    { 2, "Pear", 1.20m, 20 },
                    { 3, "Orange", 0.79m, 50 }
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Carrot", 0.45m, 120 },
                    { 2, "Beet", 0.65m, 14 },
                    { 3, "Onion", 0.20m, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cookwares",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cookwares",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cookwares",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fruits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fruits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fruits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
