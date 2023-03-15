using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class ForeginKeyv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 10, 15, 789, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 10, 15, 789, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 10, 15, 789, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 10, 15, 789, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 10, 15, 789, DateTimeKind.Local).AddTicks(2652));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 7, 29, 264, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 7, 29, 264, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 7, 29, 264, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 7, 29, 264, DateTimeKind.Local).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 7, 29, 264, DateTimeKind.Local).AddTicks(3836));
        }
    }
}
