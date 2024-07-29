using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Duckeebs.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NotRequiredRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keycaps_KeycapSets_KeycapSetId",
                table: "Keycaps");

            migrationBuilder.AlterColumn<int>(
                name: "KeycapSetId",
                table: "Keycaps",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Keycaps_KeycapSets_KeycapSetId",
                table: "Keycaps",
                column: "KeycapSetId",
                principalTable: "KeycapSets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Keycaps_KeycapSets_KeycapSetId",
                table: "Keycaps");

            migrationBuilder.AlterColumn<int>(
                name: "KeycapSetId",
                table: "Keycaps",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Keycaps_KeycapSets_KeycapSetId",
                table: "Keycaps",
                column: "KeycapSetId",
                principalTable: "KeycapSets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
