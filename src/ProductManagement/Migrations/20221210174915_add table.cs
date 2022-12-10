using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.Migrations
{
    /// <inheritdoc />
    public partial class addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    createdat = table.Column<long>(name: "created_at", type: "bigint", nullable: true),
                    updatedat = table.Column<long>(name: "updated_at", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.email);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderid = table.Column<string>(name: "order_id", type: "nvarchar(450)", nullable: false),
                    paymenttype = table.Column<int>(name: "payment_type", type: "int", nullable: false),
                    paymentstatus = table.Column<int>(name: "payment_status", type: "int", nullable: false),
                    orderstatus = table.Column<int>(name: "order_status", type: "int", nullable: false),
                    totalprice = table.Column<int>(name: "total_price", type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shippingcost = table.Column<int>(name: "shipping_cost", type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdat = table.Column<long>(name: "created_at", type: "bigint", nullable: true),
                    updatedat = table.Column<long>(name: "updated_at", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderid);
                });

            migrationBuilder.CreateTable(
                name: "OrderRow",
                columns: table => new
                {
                    orderrowid = table.Column<int>(name: "order_row_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orderid = table.Column<string>(name: "order_id", type: "nvarchar(max)", nullable: false),
                    productid = table.Column<string>(name: "product_id", type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    createdat = table.Column<long>(name: "created_at", type: "bigint", nullable: true),
                    updatedat = table.Column<long>(name: "updated_at", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRow", x => x.orderrowid);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productid = table.Column<string>(name: "product_id", type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageurl = table.Column<string>(name: "image_url", type: "nvarchar(max)", nullable: false),
                    createdat = table.Column<long>(name: "created_at", type: "bigint", nullable: true),
                    updatedat = table.Column<long>(name: "updated_at", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productid);
                });

            migrationBuilder.CreateTable(
                name: "ProductImportRecord",
                columns: table => new
                {
                    productimportid = table.Column<int>(name: "product_import_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<string>(name: "product_id", type: "nvarchar(max)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    createdat = table.Column<long>(name: "created_at", type: "bigint", nullable: true),
                    updatedat = table.Column<long>(name: "updated_at", type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImportRecord", x => x.productimportid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderRow");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductImportRecord");
        }
    }
}
