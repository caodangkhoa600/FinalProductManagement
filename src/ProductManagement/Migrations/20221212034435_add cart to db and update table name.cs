using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManagement.Migrations
{
    /// <inheritdoc />
    public partial class addcarttodbandupdatetablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImportRecord",
                table: "ProductImportRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderRow",
                table: "OrderRow");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "product");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "order");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "account");

            migrationBuilder.RenameTable(
                name: "ProductImportRecord",
                newName: "product_import");

            migrationBuilder.RenameTable(
                name: "OrderRow",
                newName: "order_row");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product",
                table: "product",
                column: "product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_account",
                table: "account",
                column: "email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_import",
                table: "product_import",
                column: "product_import_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order_row",
                table: "order_row",
                column: "order_row_id");

            migrationBuilder.CreateTable(
                name: "cart",
                columns: table => new
                {
                    productid = table.Column<string>(name: "product_id", type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedAt = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart", x => new { x.email, x.productid });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product",
                table: "product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_account",
                table: "account");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_import",
                table: "product_import");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order_row",
                table: "order_row");

            migrationBuilder.RenameTable(
                name: "product",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "account",
                newName: "Account");

            migrationBuilder.RenameTable(
                name: "product_import",
                newName: "ProductImportRecord");

            migrationBuilder.RenameTable(
                name: "order_row",
                newName: "OrderRow");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "product_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImportRecord",
                table: "ProductImportRecord",
                column: "product_import_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderRow",
                table: "OrderRow",
                column: "order_row_id");
        }
    }
}
