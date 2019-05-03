using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.Migrations
{
    public partial class SeedGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Groups (Code, Capacity) VALUES" +
                "('A1', 7)");
            migrationBuilder.Sql("INSERT INTO Groups (Code, Capacity) VALUES" +
                "('B1', 7)");
            migrationBuilder.Sql("INSERT INTO Groups (Code, Capacity) VALUES" +
                "('C1', 7)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
