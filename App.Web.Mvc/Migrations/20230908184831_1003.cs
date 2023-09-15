using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMvcBlog.Migrations
{
    /// <inheritdoc />
    public partial class _1003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Page_Post_PostId",
                table: "Page");

            migrationBuilder.DropIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage");

            migrationBuilder.DropIndex(
                name: "IX_Page_PostId",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Page");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "Post",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PageContext",
                table: "Page",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PageTitle",
                table: "Page",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "CategoryPost",
                columns: new[] { "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Page",
                columns: new[] { "Id", "PageContext", "PageTitle" },
                values: new object[,]
                {
                    { 1, "Sed convallis, augue sit amet aliquet tempor, eros eros fringilla libero, ultrices placerat urna augue eu nisl. Praesent suscipit viverra nulla, sed condimentum ante iaculis eget. Nam auctor faucibus metus, non gravida leo pellentesque et.", "About" },
                    { 2, " Etiam ultricies pharetra elit, eget vulputate odio. Fusce facilisis in lacus id lacinia. In ex lacus, convallis nec sapien non, placerat consectetur ipsum. Quisque cursus ligula id ullamcorper sagittis. Vivamus ultricies mollis augue. Nunc vel erat vitae purus vestibulum egestas.", "Contact" }
                });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2019, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "PostImage",
                columns: new[] { "Id", "ImageUrl", "PostId" },
                values: new object[,]
                {
                    { 1, "../images/slider/slider1.jpg", 1 },
                    { 2, "../images/slider/slider2.jpg", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage");

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryPost",
                keyColumns: new[] { "CategoryId", "PostId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Page",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostImage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "PageContext",
                table: "Page");

            migrationBuilder.DropColumn(
                name: "PageTitle",
                table: "Page");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Page",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PostImage_PostId",
                table: "PostImage",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Page_PostId",
                table: "Page",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Page_Post_PostId",
                table: "Page",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
