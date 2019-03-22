using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaleSystemCore.Migrations
{
    public partial class m7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleInvoicePayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false),
                    PayTypeID = table.Column<int>(nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoicePayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoicePaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    IsConnectedToPos = table.Column<bool>(nullable: false),
                    ConnectedPortType = table.Column<string>(maxLength: 150, nullable: true),
                    ConnectedPortNumber = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentUrl = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentApi = table.Column<string>(maxLength: 150, nullable: true),
                    OnlinePaymentKey = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoicePaymentTypes", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "SaleInvoicePaymentTypes",
                columns: new[] { "Id", "ConnectedPortNumber", "ConnectedPortType", "CreateDate", "Description", "IsActive", "IsConnectedToPos", "OnlinePaymentApi", "OnlinePaymentKey", "OnlinePaymentUrl", "Title" },
                values: new object[] { 1, null, null, new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(2066), null, true, false, null, null, null, "Cash" });

            migrationBuilder.InsertData(
                table: "SaleInvoicePaymentTypes",
                columns: new[] { "Id", "ConnectedPortNumber", "ConnectedPortType", "CreateDate", "Description", "IsActive", "IsConnectedToPos", "OnlinePaymentApi", "OnlinePaymentKey", "OnlinePaymentUrl", "Title" },
                values: new object[] { 2, null, null, new DateTime(2019, 3, 22, 23, 33, 52, 567, DateTimeKind.Local).AddTicks(2765), null, true, false, null, null, null, "BankPOS" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleInvoicePayments");

            migrationBuilder.DropTable(
                name: "SaleInvoicePaymentTypes");

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
    }
}
