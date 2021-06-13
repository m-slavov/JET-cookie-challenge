using Microsoft.EntityFrameworkCore.Migrations;

namespace JETCookies.Migrations
{
    public partial class ImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "IngredientItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "CookieItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "IngredientItems");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "CookieItems");
        }
    }
}
