using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "IsOur", "MessageDate", "MessageText", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 1, true, new DateTime(2023, 5, 27, 12, 4, 51, 893, DateTimeKind.Local).AddTicks(7297), "Hi", 1, "Bob" },
                    { 2, 1, false, new DateTime(2023, 5, 27, 12, 5, 51, 893, DateTimeKind.Local).AddTicks(7312), "Hello", 2, "Alice" },
                    { 3, 1, true, new DateTime(2023, 5, 27, 12, 6, 51, 893, DateTimeKind.Local).AddTicks(7317), "How are you?", 1, "Bob" },
                    { 4, 1, false, new DateTime(2023, 5, 27, 12, 7, 51, 893, DateTimeKind.Local).AddTicks(7318), "I'm good, thanks!", 2, "Alice" },
                    { 5, 1, true, new DateTime(2023, 5, 27, 12, 8, 51, 893, DateTimeKind.Local).AddTicks(7321), "What have you been up to?", 1, "Bob" },
                    { 6, 1, false, new DateTime(2023, 5, 27, 12, 9, 51, 893, DateTimeKind.Local).AddTicks(7323), "Not much, just working on a project", 2, "Alice" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
