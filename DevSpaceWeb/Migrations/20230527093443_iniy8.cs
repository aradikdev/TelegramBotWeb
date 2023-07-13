using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class iniy8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 34, 43, 169, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 35, 43, 169, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 36, 43, 169, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 37, 43, 169, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 38, 43, 169, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsSended", "MessageDate" },
                values: new object[] { true, new DateTime(2023, 5, 27, 15, 39, 43, 169, DateTimeKind.Local).AddTicks(6618) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
