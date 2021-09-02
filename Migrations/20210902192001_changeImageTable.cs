using Microsoft.EntityFrameworkCore.Migrations;

namespace homework_52.Migrations
{
    public partial class changeImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Images");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "ImageModel");

            migrationBuilder.AddColumn<int>(
                name: "ImageModelId",
                table: "Products",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageModelId",
                table: "Products",
                column: "ImageModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ImageModel_ImageModelId",
                table: "Products",
                column: "ImageModelId",
                principalTable: "ImageModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ImageModel_ImageModelId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ImageModelId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageModel",
                table: "ImageModel");

            migrationBuilder.DropColumn(
                name: "ImageModelId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ImageModel",
                newName: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Images",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
