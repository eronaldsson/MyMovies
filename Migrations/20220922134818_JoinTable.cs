using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovies.Migrations
{
    public partial class JoinTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WatchList",
                columns: table => new
                {
                    WatchListId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyRating = table.Column<decimal>(type: "decimal(3,1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchList", x => x.WatchListId);
                });

            migrationBuilder.CreateTable(
                name: "WatchListMovies",
                columns: table => new
                {
                    WatchListMoviesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchListId = table.Column<long>(type: "bigint", nullable: false),
                    MovieId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchListMovies", x => x.WatchListMoviesId);
                    table.ForeignKey(
                        name: "FK_WatchListMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchListMovies_WatchList_WatchListId",
                        column: x => x.WatchListId,
                        principalTable: "WatchList",
                        principalColumn: "WatchListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WatchListMovies_MovieId",
                table: "WatchListMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchListMovies_WatchListId",
                table: "WatchListMovies",
                column: "WatchListId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WatchListMovies");

            migrationBuilder.DropTable(
                name: "WatchList");
        }
    }
}
