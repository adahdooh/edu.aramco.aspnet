using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace edu.aramco.aspnet.scaffold.Migrations
{
    /// <inheritdoc />
    public partial class add_prop_zz_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "new_property",
                table: "_zz",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "new_property",
                table: "_zz");
        }
    }
}
