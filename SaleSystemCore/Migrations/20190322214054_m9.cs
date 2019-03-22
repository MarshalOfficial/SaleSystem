using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "StockAdjustmentInvoiceCounter",
                table: "GlobalSetting",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "StockAdjustment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceNumber = table.Column<string>(maxLength: 150, nullable: true),
                    InvoiceDate = table.Column<DateTime>(nullable: true),
                    UserID = table.Column<int>(nullable: false),
                    IsOutput = table.Column<bool>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SumPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentDetailsTemp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Qty = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentDetailsTemp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockAdjustmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAdjustmentTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "GlobalSetting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "StockAdjustmentInvoiceCounter" },
                values: new object[] { new DateTime(2019, 3, 23, 2, 10, 53, 559, DateTimeKind.Local).AddTicks(5353), 1L });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreateDate", "IsActive", "PermKey" },
                values: new object[] { 7, new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(7778), true, "StockAdjustmentModule" });

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "SaleInvoicePaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(5460), true, "Periodic Counting" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(6206), true, "Waste Products" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(6233), true, "Management Consumption" });

            migrationBuilder.InsertData(
                table: "StockAdjustmentTypes",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 4, new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(6237), true, "Test Usage of Product" });

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 591, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 3, new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(361), true, "StockAdjustment" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 2, 10, 53, 592, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.CreateIndex(
                name: "IX_StockAdjustment_InvoiceNumber",
                table: "StockAdjustment",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockAdjustment");

            migrationBuilder.DropTable(
                name: "StockAdjustmentDetails");

            migrationBuilder.DropTable(
                name: "StockAdjustmentDetailsTemp");

            migrationBuilder.DropTable(
                name: "StockAdjustmentTypes");

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StockLogType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "StockAdjustmentInvoiceCounter",
                table: "GlobalSetting");

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

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 406, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "PurchaseInvoiceType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2019, 3, 23, 0, 54, 2, 407, DateTimeKind.Local).AddTicks(530));

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
    }
}
