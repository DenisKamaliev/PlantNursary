using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantNursary.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "breedings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breedings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "greenHouses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_greenHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nurses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QueenCells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueenCells", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "beds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BreedingSectorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_beds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_beds_breedings_BreedingSectorId",
                        column: x => x.BreedingSectorId,
                        principalTable: "breedings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "sectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_sectors_fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "fields",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "lines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    events = table.Column<int[]>(type: "integer[]", nullable: false),
                    SectorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lines_sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "sectors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "plants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BirthDay = table.Column<DateOnly>(type: "date", nullable: false),
                    plantType = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    height = table.Column<int>(type: "integer", nullable: false),
                    diameter = table.Column<int>(type: "integer", nullable: false),
                    hardinessType = table.Column<int>(type: "integer", nullable: false),
                    placeType = table.Column<int>(type: "integer", nullable: false),
                    groundType = table.Column<int>(type: "integer", nullable: false),
                    Peculiarities = table.Column<string>(type: "text", nullable: true),
                    LineId = table.Column<Guid>(type: "uuid", nullable: true),
                    ReservationId = table.Column<Guid>(type: "uuid", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Updated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_plants_lines_LineId",
                        column: x => x.LineId,
                        principalTable: "lines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_plants_reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "reservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_beds_BreedingSectorId",
                table: "beds",
                column: "BreedingSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_lines_SectorId",
                table: "lines",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_plants_LineId",
                table: "plants",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_plants_ReservationId",
                table: "plants",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_sectors_FieldId",
                table: "sectors",
                column: "FieldId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "beds");

            migrationBuilder.DropTable(
                name: "greenHouses");

            migrationBuilder.DropTable(
                name: "nurses");

            migrationBuilder.DropTable(
                name: "plants");

            migrationBuilder.DropTable(
                name: "QueenCells");

            migrationBuilder.DropTable(
                name: "breedings");

            migrationBuilder.DropTable(
                name: "lines");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "sectors");

            migrationBuilder.DropTable(
                name: "fields");
        }
    }
}
