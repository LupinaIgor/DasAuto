using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationCar.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameMainImageIdToMainImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MainImageId",
                table: "ConfigurationColors",
                newName: "MainImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MainImageUrl",
                table: "ConfigurationColors",
                newName: "MainImageId");
        }
    }
}
