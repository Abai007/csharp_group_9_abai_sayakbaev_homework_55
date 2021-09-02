using Microsoft.EntityFrameworkCore.Migrations;

namespace homework_52.Migrations
{
    public partial class ChangeOfTableImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Images_ImageId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "Images",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ImageId",
                table: "Images",
                newName: "IX_Images_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Products_ProductId",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Images",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                newName: "IX_Images_ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Images_ImageId",
                table: "Images",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
