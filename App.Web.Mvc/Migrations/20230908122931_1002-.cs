using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetMvcBlog.Migrations
{
    /// <inheritdoc />
    public partial class _1002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "a@gmail.com", "a", "a", "1234", "a" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "s@hotmail.com", "s", "sss", "1234", "snake" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "Kartal@gmail.com", "Kartal", "laklak", "12345", "lako" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UserEmail", "UserName", "UserNick", "UserPassword", "UserSurname" },
                values: new object[] { "Zekimuren@hotmail.com", "Zeki", "murenbalıgı", "12345", "Muren" });
        }
    }
}
