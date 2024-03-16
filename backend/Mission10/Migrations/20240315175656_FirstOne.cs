using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission10.Migrations
{
    /// <inheritdoc />
    public partial class FirstOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql(@"
                CREATE TABLE IF NOT EXISTS Teams (
                    TeamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TeamName TEXT
                );
            ");

            migrationBuilder.Sql(@"
                CREATE TABLE IF NOT EXISTS Bowlers (
                    BowlerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    BowlerFirstName TEXT,
                    BowlerMiddleInit TEXT,
                    BowlerLastName TEXT,
                    BowlerAddress TEXT,
                    BowlerCity TEXT,
                    BowlerState TEXT,
                    BowlerZip TEXT,
                    BowlerPhoneNumber TEXT,
                    FOREIGN KEY (TeamID) REFERENCES Teams (TeamID)
                );
            ");

            migrationBuilder.CreateIndex(
                name: "IX_Bowlers_TeamID",
                table: "Bowlers",
                column: "TeamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bowlers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
