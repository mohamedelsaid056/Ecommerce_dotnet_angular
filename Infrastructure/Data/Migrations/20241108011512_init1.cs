using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductBrandId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductBrands_ProductBrandId",
                        column: x => x.ProductBrandId,
                        principalTable: "ProductBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductBrands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Angular" },
                    { 2, "NetCore" },
                    { 3, "VS Code" },
                    { 4, "React" },
                    { 5, "Typescript" },
                    { 6, "Redis" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Boards" },
                    { 2, "Hats" },
                    { 3, "Boots" },
                    { 4, "Gloves" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "Description 1", "Angular Speedster Board 2000", "images/products/sb-ang1.png", 200.0, 1, 1 },
                    { 2, "Description 2", "Green Angular Board 3000", "images/products/sb-ang2.png", 150.0, 1, 1 },
                    { 3, "Description 3", "Core Board Speed Rush 3", "images/products/sb-core1.png", 180.0, 2, 1 },
                    { 4, "Description 4", "Net Core Super Board", "images/products/sb-core2.png", 300.0, 2, 1 },
                    { 5, "Description 5", "React Board Super Whizzy Fast", "images/products/sb-react1.png", 250.0, 4, 1 },
                    { 6, "Description 6", "Typescript Entry Board", "images/products/sb-ts1.png", 120.0, 5, 1 },
                    { 7, "Description 7", "Core Blue Hat", "images/products/hat-core1.png", 10.0, 2, 2 },
                    { 8, "Description 8", "Green React Woolen Hat", "images/products/hat-react1.png", 8.0, 4, 2 },
                    { 9, "Description 9", "Purple React Woolen Hat", "images/products/hat-react2.png", 15.0, 4, 2 },
                    { 10, "Description 10", "Blue Code Gloves", "images/products/glove-code1.png", 18.0, 3, 4 },
                    { 11, "Description 11", "Green Code Gloves", "images/products/glove-code2.png", 15.0, 3, 4 },
                    { 12, "Description 12", "Purple React Gloves", "images/products/glove-react1.png", 16.0, 4, 4 },
                    { 13, "Description 13", "Green React Gloves", "images/products/glove-react2.png", 14.0, 4, 4 },
                    { 14, "Description 14", "Redis Red Boots", "images/products/boot-redis1.png", 250.0, 6, 3 },
                    { 15, "Description 15", "Core Red Boots", "images/products/boot-core2.png", 189.99000000000001, 2, 3 },
                    { 16, "Description 16", "Core Purple Boots", "images/products/boot-core1.png", 199.99000000000001, 2, 3 },
                    { 17, "Description 17", "Angular Purple Boots", "images/products/boot-ang2.png", 150.0, 1, 3 },
                    { 18, "Description 18", "Angular Blue Boots", "images/products/boot-ang1.png", 180.0, 1, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBrandId",
                table: "Products",
                column: "ProductBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
