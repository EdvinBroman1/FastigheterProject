using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamRedWebApi.Migrations
{
    public partial class AddedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AverageRating", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, null, "Jesperceriksson@outlook.com", "123123", "Yamato" },
                    { 2, null, "JohanKarlsson@outlook.com", "sfsdifhdsofdsh/¤(#&", "Majken" },
                    { 3, null, "FelixAlexandersson@outlook.com", "dsadasdasfg/¤(#&", "Falex" },
                    { 4, null, "ErikOlofsson@gmail.com", "sfisdfiub(T(/¤(#&", "Eriko" },
                    { 5, null, "NicklasAndreasson@protonmail.com", "dasdnsafba//¤(#&", "Nickare" },
                    { 6, null, "YngveOpendal@outlook.com", "daskdjbasdkasb/¤(#&", "Yngvisen" },
                    { 7, null, "AndreasSvensson@swipnet.se", "dsfsjfdsf8/¤(#&", "mafakka" }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "AdCreated", "Address", "AverageRating", "CanBePurchased", "CanBeRented", "ConstructionYear", "Contact", "Description", "PurchasePrice", "Ratings", "RentingPrice", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 876, DateTimeKind.Unspecified).AddTicks(550), new TimeSpan(0, 2, 0, 0, 0)), "Ostindiegatan 14B", null, true, true, "1935", "0703357725", "A lovely home for a lovely family", 100000, null, 1000, "My lovely home", 2, 1 },
                    { 2, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(30), new TimeSpan(0, 2, 0, 0, 0)), "aspelundgatan 9", null, true, true, "1956", "0709765456", "A lovely home for a lovely family", 100000, null, 1000, "My cool home", 2, 2 },
                    { 3, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(135), new TimeSpan(0, 2, 0, 0, 0)), "Falsbogatan 18", null, true, true, "1999", "0709987656", "A lovely home for a lovely family", 100000, null, 1000, "My nice home", 1, 3 },
                    { 4, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(144), new TimeSpan(0, 2, 0, 0, 0)), "Höglundsgatan 15", null, true, true, "1934", "0705647356", "A lovely home for a lovely family", 100000, null, 1000, "My nice home", 2, 3 },
                    { 5, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(150), new TimeSpan(0, 2, 0, 0, 0)), "Mariaplan 5", null, true, true, "1987", "0705647356", "A lovely home for a lovely family", 100000, null, 1000, "My nice bungalow", 2, 4 },
                    { 6, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(156), new TimeSpan(0, 2, 0, 0, 0)), "Svanebäcksgatan 5", null, true, true, "1876", "0705647356", "A lovely home for a lovely family", 100000, null, 1000, "My nice bungalow", 1, 5 },
                    { 7, new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(162), new TimeSpan(0, 2, 0, 0, 0)), "Fastmansvägen 89", null, true, true, "1657", "0705647356", "A lovely home for a lovely family", 100000, null, 1000, "My nice bungalow", 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "Content", "CreatedOn", "RealEstateId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "This is a lovely home.", new DateTimeOffset(new DateTime(2020, 10, 6, 20, 28, 30, 878, DateTimeKind.Unspecified).AddTicks(1148), new TimeSpan(0, 2, 0, 0, 0)), 1, 1 },
                    { 3, null, "The premises is $100000", new DateTimeOffset(new DateTime(2003, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 2, 3 },
                    { 4, null, "Test1", new DateTimeOffset(new DateTime(2005, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 3, 3 },
                    { 5, null, "Test2", new DateTimeOffset(new DateTime(2005, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 3, 4 },
                    { 6, null, "Test3", new DateTimeOffset(new DateTime(2006, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 4, 5 },
                    { 7, null, "Test4", new DateTimeOffset(new DateTime(2007, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentId", "Content", "CreatedOn", "RealEstateId", "UserId" },
                values: new object[] { 2, 1, "How much is this home?", new DateTimeOffset(new DateTime(2003, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
