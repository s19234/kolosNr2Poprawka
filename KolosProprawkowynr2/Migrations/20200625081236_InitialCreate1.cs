using Microsoft.EntityFrameworkCore.Migrations;

namespace KolosProprawkowynr2.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Event_Artists_ArtistsIDArtist",
                table: "Artist_Event");

            migrationBuilder.DropIndex(
                name: "IX_Artist_Event_ArtistsIDArtist",
                table: "Artist_Event");

            migrationBuilder.DropColumn(
                name: "ArtistsIDArtist",
                table: "Artist_Event");

            migrationBuilder.AddColumn<int>(
                name: "ArtistIDArtist",
                table: "Artist_Event",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Event_ArtistIDArtist",
                table: "Artist_Event",
                column: "ArtistIDArtist");

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Event_Artists_ArtistIDArtist",
                table: "Artist_Event",
                column: "ArtistIDArtist",
                principalTable: "Artists",
                principalColumn: "IDArtist",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Event_Artists_ArtistIDArtist",
                table: "Artist_Event");

            migrationBuilder.DropIndex(
                name: "IX_Artist_Event_ArtistIDArtist",
                table: "Artist_Event");

            migrationBuilder.DropColumn(
                name: "ArtistIDArtist",
                table: "Artist_Event");

            migrationBuilder.AddColumn<int>(
                name: "ArtistsIDArtist",
                table: "Artist_Event",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Event_ArtistsIDArtist",
                table: "Artist_Event",
                column: "ArtistsIDArtist");

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Event_Artists_ArtistsIDArtist",
                table: "Artist_Event",
                column: "ArtistsIDArtist",
                principalTable: "Artists",
                principalColumn: "IDArtist",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
