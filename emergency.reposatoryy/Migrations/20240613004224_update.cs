using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace emergency.reposatoryy.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52626272-6b9c-446c-8b69-18217ecf1655");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f5d8aff-16bf-4a5c-a9f5-d434bab52ce7");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Hospitals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57ffb8c9-8f89-4aff-a37e-d7e324dd4d34", "2fdb53b2-aba4-4cec-91f9-1db237732872", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "673cd2a6-0a17-4661-8e61-28fb0464dc3c", "5a363505-70f4-44a2-81df-eae14cd34d3d", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57ffb8c9-8f89-4aff-a37e-d7e324dd4d34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673cd2a6-0a17-4661-8e61-28fb0464dc3c");

            migrationBuilder.AlterColumn<int>(
                name: "phone",
                table: "Hospitals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52626272-6b9c-446c-8b69-18217ecf1655", "ce0d9370-a6f3-4e3b-b053-1d46914fab76", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f5d8aff-16bf-4a5c-a9f5-d434bab52ce7", "491be154-b7f0-4854-989c-633e58436211", "Admin", "admin" });
        }
    }
}
