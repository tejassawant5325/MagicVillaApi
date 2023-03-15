using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class ForeginKeyv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 5, 6, 21, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 5, 6, 21, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 5, 6, 21, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 5, 6, 21, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 5, 6, 21, DateTimeKind.Local).AddTicks(8394));
        }
    }
}
