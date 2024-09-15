using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace emergency.reposatoryy.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57ffb8c9-8f89-4aff-a37e-d7e324dd4d34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "673cd2a6-0a17-4661-8e61-28fb0464dc3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c22b8d7c-8440-4841-a233-9a0125c4ae80", "37e9572b-1630-4b81-a4fc-5423fdb578fa", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcabe618-2c2f-4c89-9326-cbcdfcb5cb81", "6938dc11-bcd6-4f14-91a7-ac3931f73a37", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c22b8d7c-8440-4841-a233-9a0125c4ae80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcabe618-2c2f-4c89-9326-cbcdfcb5cb81");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57ffb8c9-8f89-4aff-a37e-d7e324dd4d34", "2fdb53b2-aba4-4cec-91f9-1db237732872", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "673cd2a6-0a17-4661-8e61-28fb0464dc3c", "5a363505-70f4-44a2-81df-eae14cd34d3d", "Admin", "admin" });
        }
    }
}
