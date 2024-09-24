using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_Messstation.Migrations
{
    /// <inheritdoc />
    public partial class changedwert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messwert_Messstation_MessstationenId",
                table: "Messwert");

            migrationBuilder.DropIndex(
                name: "IX_Messwert_MessstationenId",
                table: "Messwert");

            migrationBuilder.DropColumn(
                name: "MessstationenId",
                table: "Messwert");

            migrationBuilder.RenameColumn(
                name: "Messwert",
                table: "Messwert",
                newName: "Wert");

            migrationBuilder.CreateIndex(
                name: "IX_Messwert_MessstationId",
                table: "Messwert",
                column: "MessstationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messwert_Messstation_MessstationId",
                table: "Messwert",
                column: "MessstationId",
                principalTable: "Messstation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messwert_Messstation_MessstationId",
                table: "Messwert");

            migrationBuilder.DropIndex(
                name: "IX_Messwert_MessstationId",
                table: "Messwert");

            migrationBuilder.RenameColumn(
                name: "Wert",
                table: "Messwert",
                newName: "Messwert");

            migrationBuilder.AddColumn<int>(
                name: "MessstationenId",
                table: "Messwert",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Messwert_MessstationenId",
                table: "Messwert",
                column: "MessstationenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messwert_Messstation_MessstationenId",
                table: "Messwert",
                column: "MessstationenId",
                principalTable: "Messstation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
