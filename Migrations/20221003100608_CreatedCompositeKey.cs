using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovies.Migrations
{
    public partial class CreatedCompositeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchListMovies",
                table: "WatchListMovies");

            migrationBuilder.DropIndex(
                name: "IX_WatchListMovies_WatchListId",
                table: "WatchListMovies");

            migrationBuilder.DropColumn(
                name: "WatchListMoviesId",
                table: "WatchListMovies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchListMovies",
                table: "WatchListMovies",
                columns: new[] { "WatchListId", "MovieId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WatchListMovies",
                table: "WatchListMovies");

            migrationBuilder.AddColumn<long>(
                name: "WatchListMoviesId",
                table: "WatchListMovies",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WatchListMovies",
                table: "WatchListMovies",
                column: "WatchListMoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchListMovies_WatchListId",
                table: "WatchListMovies",
                column: "WatchListId");
        }
    }
}
