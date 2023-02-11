using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyCore.Migrations
{
    /// <inheritdoc />
    public partial class denee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                type: "Varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Admins",
                type: "Varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(50)");
        }
    }
}
