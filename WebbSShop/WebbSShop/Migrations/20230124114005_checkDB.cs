using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebbSShop.Migrations
{
    /// <inheritdoc />
    public partial class checkDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    lname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    adress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    dicsount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    price = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SuperMarkets",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    adress = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperMarkets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerid = table.Column<int>(name: "customer_id", type: "int", nullable: true),
                    supermarketid = table.Column<int>(name: "supermarket_id", type: "int", nullable: true),
                    orderdate = table.Column<DateTime>(name: "order_date", type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers",
                        column: x => x.customerid,
                        principalTable: "Customers",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Orders_SuperMarkets",
                        column: x => x.supermarketid,
                        principalTable: "SuperMarkets",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDatails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderid = table.Column<int>(name: "order_id", type: "int", nullable: true),
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: true),
                    quantity = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDatails", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDatails_Orders",
                        column: x => x.orderid,
                        principalTable: "Orders",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_OrderDatails_Products",
                        column: x => x.productid,
                        principalTable: "Products",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDatails_order_id",
                table: "OrderDatails",
                column: "order_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDatails_product_id",
                table: "OrderDatails",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_customer_id",
                table: "Orders",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_supermarket_id",
                table: "Orders",
                column: "supermarket_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDatails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "SuperMarkets");
        }
    }
}
