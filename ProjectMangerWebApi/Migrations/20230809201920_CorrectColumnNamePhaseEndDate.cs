using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectMangerWebApi.Migrations
{
    /// <inheritdoc />
    public partial class CorrectColumnNamePhaseEndDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EntDate",
                table: "Phases",
                newName: "EndDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Phases",
                newName: "EntDate");
        }
    }
}
