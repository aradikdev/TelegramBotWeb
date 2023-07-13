using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DevSpaceWeb.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Messages");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastMessage = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "IsActive", "LastMessage", "Name" },
                values: new object[,]
                {
                    { 1, true, null, "Bob" },
                    { 2, false, null, "Alice" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_User_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_User_UserId",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 4, 51, 893, DateTimeKind.Local).AddTicks(7297), "Bob" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 5, 51, 893, DateTimeKind.Local).AddTicks(7312), "Alice" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 6, 51, 893, DateTimeKind.Local).AddTicks(7317), "Bob" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 7, 51, 893, DateTimeKind.Local).AddTicks(7318), "Alice" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 8, 51, 893, DateTimeKind.Local).AddTicks(7321), "Bob" });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MessageDate", "UserName" },
                values: new object[] { new DateTime(2023, 5, 27, 12, 9, 51, 893, DateTimeKind.Local).AddTicks(7323), "Alice" });
        }
    }
}
