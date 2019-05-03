using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Api.Migrations
{
    public partial class SeedCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Courses (Name, DoctorCode, HospitalName, StartDate, EndDate, GroupID)" +
               " VALUES ('General Surgery', 'M01', 'NNU', '2019-7-1', '2019-7-7', 1)");
            migrationBuilder.Sql("INSERT INTO Courses (Name, DoctorCode, HospitalName, StartDate, EndDate, GroupID)" +
               " VALUES ('Internal Medicine', 'M02', 'Tobas', '2019-7-1', '2019-7-7', 2)");
            migrationBuilder.Sql("INSERT INTO Courses (Name, DoctorCode, HospitalName, StartDate, EndDate, GroupID)" +
               " VALUES ('Pediatrics', 'M03', 'Jenin', '2019-7-1', '2019-7-7', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
