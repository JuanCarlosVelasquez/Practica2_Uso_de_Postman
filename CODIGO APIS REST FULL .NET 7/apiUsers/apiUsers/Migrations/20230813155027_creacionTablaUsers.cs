using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiUsers.Migrations
{
    /// <inheritdoc />
    public partial class creacionTablaUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    idUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificationUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nameUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    passwordUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createUser = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.idUser);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
