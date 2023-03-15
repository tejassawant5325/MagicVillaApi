using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedVillaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 18, 30, 549, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 18, 30, 549, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 18, 30, 549, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 18, 30, 549, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 18, 30, 549, DateTimeKind.Local).AddTicks(6958));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 16, 24, 401, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 16, 24, 401, DateTimeKind.Local).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 16, 24, 401, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 16, 24, 401, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 23, 11, 16, 24, 401, DateTimeKind.Local).AddTicks(5104));
        }
    }
}
