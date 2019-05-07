using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class in_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 564, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 585, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 5, 7, 16, 2, 34, 586, DateTimeKind.Local).AddTicks(1153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 525, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "StockAdjustmentTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 552, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 25, 19, 23, 31, 553, DateTimeKind.Local).AddTicks(4677));
        }
    }
}
