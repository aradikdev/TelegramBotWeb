using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 28, 29, 916, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 29, 29, 916, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 30, 29, 916, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 31, 29, 916, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 32, 29, 916, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 33, 29, 916, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 27, 2, 43, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 28, 2, 43, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 29, 2, 43, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 30, 2, 43, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 31, 2, 43, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageDate",
                value: new DateTime(2023, 5, 27, 12, 32, 2, 43, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: false);
        }
    }
}
