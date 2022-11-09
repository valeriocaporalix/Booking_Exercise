using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking_Exercise.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "Address", "Name" },
                values: new object[,]
                {
                    { 11, "Via Test 10", "Hotel TestOne" },
                    { 12, "Via Test 10", "Hotel TestTwo" },
                    { 13, "Via Test 10", "Hotel TestThree" },
                    { 14, "Via Test 10", "Hotel TestFour" },
                    { 15, "Via Test 10", "Hotel TestFive" },
                    { 16, "Via Test 10", "Hotel TestSix" },
                    { 17, "Via Test 10", "Hotel TestSeven" },
                    { 18, "Via Test 10", "Hotel TestEight" },
                    { 19, "Via Test 10", "Hotel TestNine" },
                    { 20, "Via Test 10", "Hotel TestTen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 20);
        }
    }
}
