using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrlShortener.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNormalizedShortCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortCodeNormalized",
                table: "short_urls",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_short_urls_ShortCodeNormalized",
                table: "short_urls",
                column: "ShortCodeNormalized",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_short_urls_ShortCodeNormalized",
                table: "short_urls");

            migrationBuilder.DropColumn(
                name: "ShortCodeNormalized",
                table: "short_urls");
        }
    }
}
