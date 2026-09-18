using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppMvc.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCamposTarefa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Banco");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Banco",
                newName: "Title");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Banco",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Banco");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Banco",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Banco",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
