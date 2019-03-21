using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "StockLog",
                maxLength: 150,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 758, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 790, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 791, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 2, 38, 4, 791, DateTimeKind.Local).AddTicks(2988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "StockLog");

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 161, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 187, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(2045));
        }
    }
}
