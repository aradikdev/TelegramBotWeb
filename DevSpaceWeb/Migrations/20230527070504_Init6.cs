using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 5, 4, 379, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 6, 4, 379, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 7, 4, 379, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 8, 4, 379, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 9, 4, 379, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 10, 4, 379, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChatId", "Name" },
                values: new object[] { 1, "Я" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChatId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ChatId",
                table: "Messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 30, 33, 402, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 31, 33, 402, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 32, 33, 402, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 33, 33, 402, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 34, 33, 402, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 12, 35, 33, 402, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bob");
        }
    }
}
