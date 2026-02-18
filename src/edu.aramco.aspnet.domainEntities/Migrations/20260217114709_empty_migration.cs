using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edu.aramco.aspnet.domainEntities.Migrations
{
    /// <inheritdoc />
    public partial class empty_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                create view GetAllSMS as 
                select * from SMSs
                """);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
