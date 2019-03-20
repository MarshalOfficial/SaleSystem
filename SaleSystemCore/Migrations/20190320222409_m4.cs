using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserPermissions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StockLog");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Stock");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SaleInvoiceDetailsTemp");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SaleInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SaleInvoice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PurchaseInvoiceDetailsTemp");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PurchaseInvoiceDetails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PurchaseInvoice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductsProvider");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductsCategory");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductsBrand");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GlobalSetting");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 40, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 1, 54, 9, 65, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mobile",
                table: "Users",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoice_InvoiceNumber",
                table: "SaleInvoice",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseInvoice_InvoiceNumber",
                table: "PurchaseInvoice",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Barcode",
                table: "Products",
                column: "Barcode",
                unique: true,
                filter: "[Barcode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermKey",
                table: "Permissions",
                column: "PermKey",
                unique: true,
                filter: "[PermKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Mobile",
                table: "Customers",
                column: "Mobile",
                unique: true,
                filter: "[Mobile] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Mobile",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_SaleInvoice_InvoiceNumber",
                table: "SaleInvoice");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseInvoice_InvoiceNumber",
                table: "PurchaseInvoice");

            migrationBuilder.DropIndex(
                name: "IX_Products_Barcode",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_PermKey",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_Customers_Mobile",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserPermissions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StockLog",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Stock",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SaleInvoiceDetailsTemp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SaleInvoiceDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SaleInvoice",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PurchaseInvoiceDetailsTemp",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PurchaseInvoiceDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PurchaseInvoice",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductsProvider",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductsCategory",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductsBrand",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Permissions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GlobalSetting",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 927, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 20, 20, 21, 10, 933, DateTimeKind.Local).AddTicks(5788));
        }
    }
}
