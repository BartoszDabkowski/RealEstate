using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedLatAndLongToCityAndCountyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 47.9129, Longitude = -122.0982 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Snohomish')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 47.8406, Longitude = -122.1222 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Clearview')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 47.9790, Longitude = -122.2021 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Everett')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 47.6062, Longitude = -122.3321 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Seattle')");

            migrationBuilder.Sql("UPDATE Counties SET Latitude = 48.0330, Longitude = -121.8339 WHERE Id = (SELECT ID FROM Counties WHERE Name = 'Snohomish')");
            migrationBuilder.Sql("UPDATE Counties SET Latitude = 47.5480, Longitude = -121.9836 WHERE Id = (SELECT ID FROM Counties WHERE Name = 'King')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Snohomish')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Clearview')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Everett')");
            migrationBuilder.Sql("UPDATE Cities SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Cities WHERE Name = 'Seattle')");

            migrationBuilder.Sql("UPDATE Counties SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Counties WHERE Name = 'Snohomish')");
            migrationBuilder.Sql("UPDATE Counties SET Latitude = 0.0, Longitude = 0.0 WHERE Id = (SELECT ID FROM Counties WHERE Name = 'King')");
        }
    }
}
