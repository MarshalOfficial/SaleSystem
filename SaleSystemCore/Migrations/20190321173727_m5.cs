using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseInvoiceID",
                table: "StockLog");

            migrationBuilder.DropColumn(
                name: "SaleInvoiceID",
                table: "StockLog");

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "StockLog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StockLogType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLogType", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 1, new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(377), true, "PurchaseInvoice" });

            migrationBuilder.InsertData(
                table: "StockLogType",
                columns: new[] { "Id", "CreateDate", "IsActive", "Title" },
                values: new object[] { 2, new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(1094), true, "SaleInvoice" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2019, 3, 21, 21, 7, 27, 188, DateTimeKind.Local).AddTicks(2045));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockLogType");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "StockLog");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseInvoiceID",
                table: "StockLog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SaleInvoiceID",
                table: "StockLog",
                nullable: true);

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
        }
    }
}
