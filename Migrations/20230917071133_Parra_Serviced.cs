using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSA_AB_YM_JS.Migrations
{
    /// <inheritdoc />
    public partial class Parra_Serviced : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    GivenName = table.Column<string>(type: "TEXT", nullable: true),
                    Surname = table.Column<string>(type: "TEXT", nullable: true),
                    postcode = table.Column<string>(type: "TEXT", nullable: true),
                    TheBookings = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.email);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Traveller");
        }
    }
}
