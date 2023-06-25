using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zaliczenie.Migrations
{
    /// <inheritdoc />
    public partial class initer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Pesel",
                table: "userr",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 11);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Pesel",
                table: "userr",
                type: "float",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);
        }
    }
}
