using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bookstore.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sub = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: true),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataType = table.Column<int>(type: "integer", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false, defaultValueSql: "decode('0000000000000000', 'hex')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CorrelationId = table.Column<string>(type: "text", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCart", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressLine1 = table.Column<string>(type: "text", nullable: false),
                    AddressLine2 = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: true),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: false),
                    BookTypeId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false),
                    ConditionId = table.Column<int>(type: "integer", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "text", nullable: true),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false, defaultValueSql: "decode('0000000000000000', 'hex')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_ReferenceData_BookTypeId",
                        column: x => x.BookTypeId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_ReferenceData_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_ReferenceData_GenreId",
                        column: x => x.GenreId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_ReferenceData_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Author = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    BookName = table.Column<string>(type: "text", nullable: false),
                    FrontUrl = table.Column<string>(type: "text", nullable: true),
                    GenreId = table.Column<int>(type: "integer", nullable: false),
                    ConditionId = table.Column<int>(type: "integer", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: false),
                    BookTypeId = table.Column<int>(type: "integer", nullable: false),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    OfferStatus = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    BookPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offer_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offer_ReferenceData_BookTypeId",
                        column: x => x.BookTypeId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offer_ReferenceData_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offer_ReferenceData_GenreId",
                        column: x => x.GenreId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offer_ReferenceData_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "ReferenceData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ShoppingCartId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    WantToBuy = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItem_ShoppingCart_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<string>(type: "text", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "bytea", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ReferenceData",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DataType", "Text", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8654), 2, "Hardcover", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8658) },
                    { 2, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8661), 2, "Trade Paperback", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8662) },
                    { 3, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8662), 2, "Mass Market Paperback", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8663) },
                    { 4, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8664), 1, "New", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8664) },
                    { 5, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8665), 1, "Like New", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8665) },
                    { 6, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8666), 1, "Good", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8666) },
                    { 7, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8667), 1, "Acceptable", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8667) },
                    { 8, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8668), 3, "Biographies", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8668) },
                    { 9, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8669), 3, "Children's Books", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8669) },
                    { 10, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8670), 3, "History", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8670) },
                    { 11, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8671), 3, "Literature & Fiction", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8671) },
                    { 12, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8672), 3, "Mystery, Thriller & Suspense", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8672) },
                    { 13, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673), 3, "Science Fiction & Fantasy", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673) },
                    { 14, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8673), 3, "Travel", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8674) },
                    { 15, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8674), 0, "Arcadia Books", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8675) },
                    { 16, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8675), 0, "Astral Publishing", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8676) },
                    { 17, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8676), 0, "Moonlight Publishing", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8677) },
                    { 18, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8677), 0, "Dreamscape Press", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8678) },
                    { 19, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8678), 0, "Enchanted Library", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679) },
                    { 20, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679), 0, "Fantasia House", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8679) },
                    { 21, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8759), 0, "Horizon Books", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8760) },
                    { 22, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8760), 0, "Infinity Press", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8761) },
                    { 23, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8761), 0, "Paradigm Publishing", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8762) },
                    { 24, "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8763), 0, "Aurora Publishing", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8763) }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "BookTypeId", "ConditionId", "CoverImageUrl", "CreatedBy", "CreatedOn", "GenreId", "ISBN", "Name", "Price", "PublisherId", "Quantity", "Summary", "UpdatedOn", "Year" },
                values: new object[,]
                {
                    { 1, "Li Juan", 1, 5, "/images/coverimages/apocalypse.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8937), 13, "6556784356", "2020: The Apocalypse", 10.95m, 15, 25, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8937), null },
                    { 2, "Nikki Wolf", 1, 6, "/images/coverimages/childrenofiron.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8941), 11, "7665438976", "Children Of Iron", 13.95m, 16, 3, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8942), null },
                    { 3, "Richard Roe", 1, 5, "/images/coverimages/goldinthedark.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8943), 13, "5442280765", "Gold In The Dark", 6.50m, 17, 10, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8943), null },
                    { 4, "Pat Candella", 2, 7, "/images/coverimages/leaguesofsmoke.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8946), 11, "4556789542", "Leagues Of Smoke", 3m, 18, 1, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8946), null },
                    { 5, "Carlos Salazar", 2, 5, "/images/coverimages/alonewiththestars.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8947), 12, "4563358087", "Alone With The Stars", 15.95m, 19, 5, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8948), null },
                    { 6, "Terri Whitlock", 1, 6, "/images/coverimages/girlinthepolaroid.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8949), 12, "2354435678", "The Girl In The Polaroid", 8.25m, 20, 2, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8949), null },
                    { 7, "Mary Major", 2, 5, "/images/coverimages/1001jokes.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8950), 11, "6554789632", "1001 Jokes", 13.95m, 21, 7, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8951), null },
                    { 8, "Mateo Jackson", 3, 7, "/images/coverimages/mysearchformeaning.png", "System", new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8952), 8, "4558786554", "My Search For Meaning", 5m, 22, 15, null, new DateTime(2025, 6, 23, 19, 51, 28, 486, DateTimeKind.Utc).AddTicks(8953), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CustomerId",
                table: "Address",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookTypeId",
                table: "Book",
                column: "BookTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ConditionId",
                table: "Book",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId",
                table: "Book",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Sub",
                table: "Customer",
                column: "Sub",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offer_BookTypeId",
                table: "Offer",
                column: "BookTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_ConditionId",
                table: "Offer",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_CustomerId",
                table: "Offer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_GenreId",
                table: "Offer",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Offer_PublisherId",
                table: "Offer",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_AddressId",
                table: "Order",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_BookId",
                table: "ShoppingCartItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItem_ShoppingCartId",
                table: "ShoppingCartItem",
                column: "ShoppingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offer");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "ShoppingCartItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "ShoppingCart");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "ReferenceData");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
