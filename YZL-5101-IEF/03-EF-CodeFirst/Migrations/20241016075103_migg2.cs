using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class migg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_ProfileId",
                table: "Authors",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Profiles_ProfileId",
                table: "Authors",
                column: "ProfileId",
                principalTable: "Profiles",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Profiles_ProfileId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_ProfileId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Authors");
        }
    }
}
