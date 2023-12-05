using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlantNursary.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "NursaryId",
                table: "QueenCells",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NursaryId",
                table: "GreenHouses",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NursaryId",
                table: "Fields",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "NursaryId",
                table: "Breedings",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QueenCells_NursaryId",
                table: "QueenCells",
                column: "NursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_GreenHouses_NursaryId",
                table: "GreenHouses",
                column: "NursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_NursaryId",
                table: "Fields",
                column: "NursaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Breedings_NursaryId",
                table: "Breedings",
                column: "NursaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breedings_Nurses_NursaryId",
                table: "Breedings",
                column: "NursaryId",
                principalTable: "Nurses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_Nurses_NursaryId",
                table: "Fields",
                column: "NursaryId",
                principalTable: "Nurses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GreenHouses_Nurses_NursaryId",
                table: "GreenHouses",
                column: "NursaryId",
                principalTable: "Nurses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QueenCells_Nurses_NursaryId",
                table: "QueenCells",
                column: "NursaryId",
                principalTable: "Nurses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breedings_Nurses_NursaryId",
                table: "Breedings");

            migrationBuilder.DropForeignKey(
                name: "FK_Fields_Nurses_NursaryId",
                table: "Fields");

            migrationBuilder.DropForeignKey(
                name: "FK_GreenHouses_Nurses_NursaryId",
                table: "GreenHouses");

            migrationBuilder.DropForeignKey(
                name: "FK_QueenCells_Nurses_NursaryId",
                table: "QueenCells");

            migrationBuilder.DropIndex(
                name: "IX_QueenCells_NursaryId",
                table: "QueenCells");

            migrationBuilder.DropIndex(
                name: "IX_GreenHouses_NursaryId",
                table: "GreenHouses");

            migrationBuilder.DropIndex(
                name: "IX_Fields_NursaryId",
                table: "Fields");

            migrationBuilder.DropIndex(
                name: "IX_Breedings_NursaryId",
                table: "Breedings");

            migrationBuilder.DropColumn(
                name: "NursaryId",
                table: "QueenCells");

            migrationBuilder.DropColumn(
                name: "NursaryId",
                table: "GreenHouses");

            migrationBuilder.DropColumn(
                name: "NursaryId",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "NursaryId",
                table: "Breedings");
        }
    }
}
