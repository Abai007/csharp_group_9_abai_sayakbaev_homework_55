using Microsoft.EntityFrameworkCore.Migrations;

namespace homework_52.Migrations
{
    public partial class DropPropertyImageId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ImageModel_ImageModelId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ImageModelId",
                table: "Products",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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

            migrationBuilder.AlterColumn<int>(
                name: "ImageModelId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ImageModel_ImageModelId",
                table: "Products",
                column: "ImageModelId",
                principalTable: "ImageModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
