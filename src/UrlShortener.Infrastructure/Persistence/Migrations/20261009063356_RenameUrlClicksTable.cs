using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrlShortener.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RenameUrlClicksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UrlClicks_short_urls_ShortUrlId",
                table: "UrlClicks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UrlClicks",
                table: "UrlClicks");

            migrationBuilder.RenameTable(
                name: "UrlClicks",
                newName: "url_clicks");

            migrationBuilder.RenameIndex(
                name: "IX_UrlClicks_ShortUrlId",
                table: "url_clicks",
                newName: "IX_url_clicks_ShortUrlId");

            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "url_clicks",
                type: "character varying(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Referrer",
                table: "url_clicks",
                type: "character varying(2048)",
                maxLength: 2048,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_url_clicks",
                table: "url_clicks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_url_clicks_ClickedAt",
                table: "url_clicks",
                column: "ClickedAt");

            migrationBuilder.AddForeignKey(
                name: "FK_url_clicks_short_urls_ShortUrlId",
                table: "url_clicks",
                column: "ShortUrlId",
                principalTable: "short_urls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_url_clicks_short_urls_ShortUrlId",
                table: "url_clicks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_url_clicks",
                table: "url_clicks");

            migrationBuilder.DropIndex(
                name: "IX_url_clicks_ClickedAt",
                table: "url_clicks");

            migrationBuilder.RenameTable(
                name: "url_clicks",
                newName: "UrlClicks");

            migrationBuilder.RenameIndex(
                name: "IX_url_clicks_ShortUrlId",
                table: "UrlClicks",
                newName: "IX_UrlClicks_ShortUrlId");

            migrationBuilder.AlterColumn<string>(
                name: "UserAgent",
                table: "UrlClicks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Referrer",
                table: "UrlClicks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2048)",
                oldMaxLength: 2048,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UrlClicks",
                table: "UrlClicks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UrlClicks_short_urls_ShortUrlId",
                table: "UrlClicks",
                column: "ShortUrlId",
                principalTable: "short_urls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
