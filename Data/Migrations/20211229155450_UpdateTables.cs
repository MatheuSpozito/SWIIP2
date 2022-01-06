using Microsoft.EntityFrameworkCore.Migrations;

namespace SWIIP2.Data.Migrations
{
    public partial class UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_IdUserRegisterId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_IdUserUpdateId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IdUserRegisterId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_IdUserUpdateId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdUserRegisterId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IdUserUpdateId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "UserRegister",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserUpdate",
                table: "Products",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRegister",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserUpdate",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "IdUserRegisterId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUserUpdateId",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdUserRegisterId",
                table: "Products",
                column: "IdUserRegisterId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_IdUserUpdateId",
                table: "Products",
                column: "IdUserUpdateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_IdUserRegisterId",
                table: "Products",
                column: "IdUserRegisterId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_IdUserUpdateId",
                table: "Products",
                column: "IdUserUpdateId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
