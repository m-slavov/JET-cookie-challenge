using Microsoft.EntityFrameworkCore.Migrations;

namespace JETCookies.Migrations
{
    public partial class ManyToManyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Weight",
                table: "CookieItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "CookieItems",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "IngredientItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CookieIngredients",
                columns: table => new
                {
                    CookieId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookieIngredients", x => new { x.CookieId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_CookieIngredients_CookieItems_CookieId",
                        column: x => x.CookieId,
                        principalTable: "CookieItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CookieIngredients_IngredientItems_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "IngredientItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CookieIngredients_IngredientId",
                table: "CookieIngredients",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CookieIngredients");

            migrationBuilder.DropTable(
                name: "IngredientItems");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "CookieItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "CookieItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
