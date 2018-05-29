using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Migrations
{
    public partial class SeedCitiesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Alderwood', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Arlington', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Bothell', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Brier', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Clearview', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Darrington', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Edmonds', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Everett', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Gold Bar', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Granite Falls', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Granite Falls', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Hat Island', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Indapendence', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Index', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Lake Goodwin', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Lake Stevens', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Machias', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Maltby', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Marysville', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Mill Creek', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Monroe', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Mountlake Terrace', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Mukilteo', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('North Lakewood', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Robe Valley', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Silvana', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Snohomish', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Stanwood', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Startup', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Stevens Pass', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Sultan', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Woodinville', 53061)");
            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Woodway', 53061)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Cities");
        }
    }
}
