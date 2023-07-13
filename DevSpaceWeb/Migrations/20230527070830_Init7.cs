﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 8, 30, 511, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 9, 30, 511, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 10, 30, 511, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 11, 30, 511, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 12, 30, 511, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 13, 13, 30, 511, DateTimeKind.Local).AddTicks(1812) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Messages");

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
        }
    }
}
