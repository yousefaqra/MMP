using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.Migrations
{
    public partial class SeedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Studentss (Name, NumberOfHourse, GDPA, Gender, Toofel, IsSubscribed, GroupID)" +
               " VALUES ('Ahmad', 250, 2.66, 'M', 'True', 'True', 1)");
            migrationBuilder.Sql("INSERT INTO Studentss (Name, NumberOfHourse, GDPA, Gender, Toofel, IsSubscribed, GroupID)" +
               " VALUES ('Ali', 250, 3.66, 'M', 'True', 'True', 2)");
            migrationBuilder.Sql("INSERT INTO Studentss (Name, NumberOfHourse, GDPA, Gender, Toofel, IsSubscribed, GroupID)" +
               " VALUES ('Yzn', 250, 3.16, 'M', 'True', 'True', 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
