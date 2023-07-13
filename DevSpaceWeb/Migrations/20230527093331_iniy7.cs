using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class iniy7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSended",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 33, 31, 777, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 34, 31, 777, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 35, 31, 777, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 36, 31, 777, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 37, 31, 777, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { false, new DateTime(2023, 5, 27, 15, 38, 31, 777, DateTimeKind.Local).AddTicks(6806) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSended",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 8, 30, 511, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 9, 30, 511, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 10, 30, 511, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 11, 30, 511, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 12, 30, 511, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 13, 13, 30, 511, DateTimeKind.Local).AddTicks(1812));
        }
    }
}
