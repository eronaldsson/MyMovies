using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovies.Migrations
{
    public partial class UpdatedWatchList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchListMovies_WatchList_WatchListId",
                table: "WatchListMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList");

            migrationBuilder.DropColumn(
                name: "MyRating",
                table: "WatchList");

            migrationBuilder.RenameTable(
                name: "WatchList",
                newName: "WatchLists");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists",
                column: "WatchListId");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchListMovies_WatchLists_WatchListId",
                table: "WatchListMovies",
                column: "WatchListId",
                principalTable: "WatchLists",
                principalColumn: "WatchListId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WatchListMovies_WatchLists_WatchListId",
                table: "WatchListMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchLists",
                table: "WatchLists");

            migrationBuilder.RenameTable(
                name: "WatchLists",
                newName: "WatchList");

            migrationBuilder.AddColumn<decimal>(
                name: "MyRating",
                table: "WatchList",
                type: "decimal(3,1)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchList",
                table: "WatchList",
                column: "WatchListId");

            migrationBuilder.AddForeignKey(
                name: "FK_WatchListMovies_WatchList_WatchListId",
                table: "WatchListMovies",
                column: "WatchListId",
                principalTable: "WatchList",
                principalColumn: "WatchListId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
