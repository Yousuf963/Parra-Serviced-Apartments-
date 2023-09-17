using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSA_AB_YM_JS.Migrations
{
    /// <inheritdoc />
    public partial class addPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Traveller",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Traveller");
        }
    }
}
