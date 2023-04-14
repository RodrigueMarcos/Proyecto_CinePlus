using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace CinePlus_DAL.Migrations
{
    /// <inheritdoc />
    public partial class Second_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    role = table.Column<string>(type: "longtext", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false),
                    lastName = table.Column<string>(type: "longtext", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovScreeningID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false),
                    qtySeats = table.Column<int>(type: "int", nullable: false),
                    firstSeat = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Books_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Address = table.Column<string>(type: "longtext", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cinemas_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cinemas_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Generes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Generes_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Generes_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DirectorID = table.Column<int>(type: "int", nullable: false),
                    Synopsis = table.Column<string>(type: "longtext", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movies_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_People_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovTheaters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    QtyRows = table.Column<int>(type: "int", nullable: false),
                    QtySeats = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovTheaters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovTheaters_Cinemas_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinemas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovTheaters_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovTheaters_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovieGeneres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    GenereID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGeneres", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovieGeneres_Generes_GenereID",
                        column: x => x.GenereID,
                        principalTable: "Generes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGeneres_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MoviePeople",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePeople", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MoviePeople_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePeople_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovScreenings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    MovTheaterId = table.Column<int>(type: "int", nullable: false),
                    MovType = table.Column<string>(type: "longtext", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    modifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ModifiedById = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovScreenings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovScreenings_MovTheaters_MovTheaterId",
                        column: x => x.MovTheaterId,
                        principalTable: "MovTheaters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_People_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovScreenings_People_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CreatedById",
                table: "Books",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ModifiedById",
                table: "Books",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_CreatedById",
                table: "Cinemas",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Cinemas_ModifiedById",
                table: "Cinemas",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Generes_CreatedById",
                table: "Generes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Generes_ModifiedById",
                table: "Generes",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGeneres_GenereID",
                table: "MovieGeneres",
                column: "GenereID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGeneres_MovieID",
                table: "MovieGeneres",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePeople_MovieId",
                table: "MoviePeople",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePeople_PersonId",
                table: "MoviePeople",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CreatedById",
                table: "Movies",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorID",
                table: "Movies",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ModifiedById",
                table: "Movies",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_CreatedById",
                table: "MovScreenings",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_ModifiedById",
                table: "MovScreenings",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_MovieId",
                table: "MovScreenings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovScreenings_MovTheaterId",
                table: "MovScreenings",
                column: "MovTheaterId");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_CinemaId",
                table: "MovTheaters",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_CreatedById",
                table: "MovTheaters",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_MovTheaters_ModifiedById",
                table: "MovTheaters",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_People_ModifiedById",
                table: "People",
                column: "ModifiedById");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "MovieGeneres");

            migrationBuilder.DropTable(
                name: "MoviePeople");

            migrationBuilder.DropTable(
                name: "MovScreenings");

            migrationBuilder.DropTable(
                name: "Generes");

            migrationBuilder.DropTable(
                name: "MovTheaters");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
