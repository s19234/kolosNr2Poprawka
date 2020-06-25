using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KolosProprawkowynr2.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Event_Artists_ArtistIDArtist",
                table: "Artist_Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Event_Events_EventIdEvent",
                table: "Artist_Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist_Event",
                table: "Artist_Event");

            migrationBuilder.RenameTable(
                name: "Artist_Event",
                newName: "Artist_Events");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Event_EventIdEvent",
                table: "Artist_Events",
                newName: "IX_Artist_Events_EventIdEvent");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Event_ArtistIDArtist",
                table: "Artist_Events",
                newName: "IX_Artist_Events_ArtistIDArtist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist_Events",
                table: "Artist_Events",
                column: "id");

            migrationBuilder.InsertData(
                table: "Artist_Events",
                columns: new[] { "id", "ArtistIDArtist", "EventIdEvent", "IdArtist", "IdEvent", "PerformanceDate" },
                values: new object[] { 1, 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Events_Artists_ArtistIDArtist",
                table: "Artist_Events",
                column: "ArtistIDArtist",
                principalTable: "Artists",
                principalColumn: "IDArtist",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Events_Events_EventIdEvent",
                table: "Artist_Events",
                column: "EventIdEvent",
                principalTable: "Events",
                principalColumn: "IdEvent",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Events_Artists_ArtistIDArtist",
                table: "Artist_Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Artist_Events_Events_EventIdEvent",
                table: "Artist_Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist_Events",
                table: "Artist_Events");

            migrationBuilder.DeleteData(
                table: "Artist_Events",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Artist_Events",
                newName: "Artist_Event");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Events_EventIdEvent",
                table: "Artist_Event",
                newName: "IX_Artist_Event_EventIdEvent");

            migrationBuilder.RenameIndex(
                name: "IX_Artist_Events_ArtistIDArtist",
                table: "Artist_Event",
                newName: "IX_Artist_Event_ArtistIDArtist");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist_Event",
                table: "Artist_Event",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Event_Artists_ArtistIDArtist",
                table: "Artist_Event",
                column: "ArtistIDArtist",
                principalTable: "Artists",
                principalColumn: "IDArtist",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Artist_Event_Events_EventIdEvent",
                table: "Artist_Event",
                column: "EventIdEvent",
                principalTable: "Events",
                principalColumn: "IdEvent",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
