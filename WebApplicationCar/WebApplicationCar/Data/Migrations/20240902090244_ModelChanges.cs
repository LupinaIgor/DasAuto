using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConfigurationColors_ConfigurationColors_ConfigurationColorsModelId",
                table: "ConfigurationColors");

            migrationBuilder.DropIndex(
                name: "IX_ConfigurationColors_ConfigurationColorsModelId",
                table: "ConfigurationColors");

            migrationBuilder.DropColumn(
                name: "ConfigurationColorsModelId",
                table: "ConfigurationColors");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfigurationColorsModelId",
                table: "ConfigurationColors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationColors_ConfigurationColorsModelId",
                table: "ConfigurationColors",
                column: "ConfigurationColorsModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConfigurationColors_ConfigurationColors_ConfigurationColorsModelId",
                table: "ConfigurationColors",
                column: "ConfigurationColorsModelId",
                principalTable: "ConfigurationColors",
                principalColumn: "Id");
        }
    }
}
