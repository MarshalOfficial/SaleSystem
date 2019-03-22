using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceType",
                table: "PurchaseInvoice",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PurchaseInvoiceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseInvoiceType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 380, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 405, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(9867), true, "Purchase" });

            migrationBuilder.InsertData(
                table: "PurchaseInvoiceType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 23, 0, 54, 2, 407, DateTimeKind.Local).AddTicks(530), true, "PurchaseReturn" });

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 407, DateTimeKind.Local).AddTicks(1413));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseInvoiceType");

            migrationBuilder.DropColumn(
                name: "InvoiceType",
                table: "PurchaseInvoice");

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 541, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 566, DateTimeKind.Local).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(3655));
        }
    }
}
