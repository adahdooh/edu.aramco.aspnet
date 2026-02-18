using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace edu.aramco.aspnet.domainEntities.Migrations
{
    /// <inheritdoc />
    public partial class seeding_sms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SMSs",
                columns: new[] { "Id", "Body", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Body", "SMS 1" },
                    { 2, "Body", "SMS 2" },
                    { 3, "Body", "SMS 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SMSs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SMSs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SMSs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
