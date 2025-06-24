using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.Data.Migrations
{
    public partial class FixedDateTimeToUtc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7280), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7284), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7407), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7411), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6897), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6906), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6908), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6910), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6912), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6913), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6915), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6916), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6918), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6922), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6924), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6925), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6927), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6929), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6930), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6932), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6933), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6939), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6942), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "ReferenceData",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 6, 24, 17, 33, 35, 507, DateTimeKind.Utc).AddTicks(6944) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
