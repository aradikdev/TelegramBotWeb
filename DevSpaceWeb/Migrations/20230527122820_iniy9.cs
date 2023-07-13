using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class iniy9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "Users",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "Messages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 28, 20, 314, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 29, 20, 314, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 30, 20, 314, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 31, 20, 314, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 32, 20, 314, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1L, new DateTime(2023, 5, 27, 18, 33, 20, 314, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChatId",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChatId",
                value: 1L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ChatId",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ChatId",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 34, 43, 169, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 35, 43, 169, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 36, 43, 169, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 37, 43, 169, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 38, 43, 169, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChatId", "MessageDate" },
                values: new object[] { 1, new DateTime(2023, 5, 27, 15, 39, 43, 169, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "ChatId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "ChatId",
                value: 1);
        }
    }
}
