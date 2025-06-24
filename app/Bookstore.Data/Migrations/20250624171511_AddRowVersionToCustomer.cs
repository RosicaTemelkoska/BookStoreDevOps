using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Data.Migrations
{
    public partial class AddRowVersionToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ShoppingCartItem",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ShoppingCart",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ReferenceData",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "OrderItem",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Order",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Offer",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sub",
                table: "Customer",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Customer",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Book",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Address",
                type: "bytea",
                rowVersion: true,
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5721), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5728), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5732), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5735), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5738), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5740), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5742), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5466), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5474), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5476), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5478), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5479), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5481), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5483), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5484), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5486), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5487), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5489), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5491), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5492), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5494), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5495), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5497), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5498), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5500), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5501), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5503), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5504), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5506), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5507), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5509), new DateTime(2025, 6, 24, 17, 15, 10, 177, DateTimeKind.Utc).AddTicks(5510) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ShoppingCartItem",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ShoppingCart",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "ReferenceData",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "OrderItem",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Order",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Offer",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sub",
                table: "Customer",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Customer",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Book",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "RowVersion",
                table: "Address",
                type: "bytea",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldRowVersion: true,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8937), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8943), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8946), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8947), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8949), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8950), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8951) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8952), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8654), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8662), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8664), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8667), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8669), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8677), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8759), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8761), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8763) });
        }
    }
}
