using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zaliczenie.Migrations
{
    /// <inheritdoc />
    public partial class inite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userr",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Secondname = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Pesel = table.Column<double>(type: "float", maxLength: 11, nullable: false),
                    Osiemnascie = table.Column<bool>(type: "bit", nullable: false),
                    Opiekun = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Tel_opiekuna = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Od = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Do = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypWycieczki = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userr", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userr");
        }
    }
}
