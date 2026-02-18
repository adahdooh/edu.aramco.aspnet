using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edu.aramco.aspnet.domainEntities.Migrations
{
    /// <inheritdoc />
    public partial class seeding_sms1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SMSs",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SMSs",
                columns: new[] { "Id", "Body", "PhoneNumber" },
                values: new object[] { 2, "Body", "SMS 2" });
        }
    }
}
