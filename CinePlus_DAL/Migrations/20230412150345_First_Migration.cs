using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinePlus_DAL.Migrations
{
    /// <inheritdoc />
    public partial class First_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movScreeningBookID = table.Column<int>(type: "int", nullable: false),
                    clientID = table.Column<int>(type: "int", nullable: false),
                    qtySeats = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Generes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true),
                    MovieID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    directorID = table.Column<int>(type: "int", nullable: false),
                    synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    role = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true),
                    CinemaID = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: true),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_Cinemas_CinemaID",
                        column: x => x.CinemaID,
                        principalTable: "Cinemas",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_People_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_People_People_modifiedByID",
                        column: x => x.modifiedByID,
                        principalTable: "People",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MovTheaters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtyRows = table.Column<int>(type: "int", nullable: false),
                    QtySeats = table.Column<int>(type: "int", nullable: false),
                    CinemaID = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovTheaters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovTheaters_Cinemas_CinemaID",
                        column: x => x.CinemaID,
                        principalTable: "Cinemas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovTheaters_People_createdByID",
                        column: x => x.createdByID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovTheaters_People_modifiedByID",
                        column: x => x.modifiedByID,
                        principalTable: "People",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "MovScreenings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    movieID = table.Column<int>(type: "int", nullable: false),
                    movTheaterID = table.Column<int>(type: "int", nullable: false),
                    movType = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdByID = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    modifiedByID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovScreenings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovScreenings_MovTheaters_movTheaterID",
                        column: x => x.movTheaterID,
                        principalTable: "MovTheaters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_Movies_movieID",
                        column: x => x.movieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_People_createdByID",
                        column: x => x.createdByID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_People_modifiedByID",
                        column: x => x.modifiedByID,
                        principalTable: "People",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookID",
                table: "Booking",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_clientID",
                table: "Books",
                column: "clientID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_createdByID",
                table: "Books",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_modifiedByID",
                table: "Books",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_movScreeningBookID",
                table: "Books",
                column: "movScreeningBookID");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_createdByID",
                table: "Cinemas",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_modifiedByID",
                table: "Cinemas",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Generes_createdByID",
                table: "Generes",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_Generes_modifiedByID",
                table: "Generes",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Generes_MovieID",
                table: "Generes",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_createdByID",
                table: "Movies",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_directorID",
                table: "Movies",
                column: "directorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_modifiedByID",
                table: "Movies",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_createdByID",
                table: "MovScreenings",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_modifiedByID",
                table: "MovScreenings",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_movieID",
                table: "MovScreenings",
                column: "movieID");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_movTheaterID",
                table: "MovScreenings",
                column: "movTheaterID");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_CinemaID",
                table: "MovTheaters",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_createdByID",
                table: "MovTheaters",
                column: "createdByID");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_modifiedByID",
                table: "MovTheaters",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_People_CinemaID",
                table: "People",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_People_modifiedByID",
                table: "People",
                column: "modifiedByID");

            migrationBuilder.CreateIndex(
                name: "IX_People_MovieID",
                table: "People",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Books_BookID",
                table: "Booking",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_MovScreenings_movScreeningBookID",
                table: "Books",
                column: "movScreeningBookID",
                principalTable: "MovScreenings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_People_clientID",
                table: "Books",
                column: "clientID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_People_createdByID",
                table: "Books",
                column: "createdByID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_People_modifiedByID",
                table: "Books",
                column: "modifiedByID",
                principalTable: "People",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_People_createdByID",
                table: "Cinemas",
                column: "createdByID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_People_modifiedByID",
                table: "Cinemas",
                column: "modifiedByID",
                principalTable: "People",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Generes_Movies_MovieID",
                table: "Generes",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Generes_People_createdByID",
                table: "Generes",
                column: "createdByID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Generes_People_modifiedByID",
                table: "Generes",
                column: "modifiedByID",
                principalTable: "People",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_People_createdByID",
                table: "Movies",
                column: "createdByID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_People_directorID",
                table: "Movies",
                column: "directorID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_People_modifiedByID",
                table: "Movies",
                column: "modifiedByID",
                principalTable: "People",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_People_createdByID",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_People_modifiedByID",
                table: "Cinemas");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_People_createdByID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_People_directorID",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_People_modifiedByID",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Generes");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "MovScreenings");

            migrationBuilder.DropTable(
                name: "MovTheaters");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
