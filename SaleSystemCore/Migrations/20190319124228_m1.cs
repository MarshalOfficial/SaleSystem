using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GlobalSetting",
                columns: new[] { "Id", "CreateDate", "IsActive", "IsDeleted", "ProductBarcodeCounter", "PurchaseInvoiceCounter", "SaleInvoiceCounter", "SelectedLanguage" },
                values: new object[] { 1, new DateTime(2019, 3, 19, 16, 12, 27, 537, DateTimeKind.Local).AddTicks(405), true, false, 1L, 1L, 1L, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
