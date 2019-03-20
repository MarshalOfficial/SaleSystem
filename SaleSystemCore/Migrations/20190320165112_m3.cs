using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 927, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 1, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(3344), true, false, "UserModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 2, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4260), true, false, "ProductModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 3, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4278), true, false, "StockModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 4, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4281), true, false, "SaleModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 5, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4285), true, false, "PurchaseModule" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "PermKey" },
                values: new object[] { 6, new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4288), true, false, "CustomerModule" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(5788));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 19, 18, 11, 16, 777, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 19, 18, 11, 16, 787, DateTimeKind.Local).AddTicks(3791));
        }
    }
}
