using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedHouseTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Residential Single')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Condominium')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Land')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Land & Ranch')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Manufacturd Home')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Multi-Family')");
            migrationBuilder.Sql("INSERT INTO HouseType (Name) VALUES ('Rental')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM HouseType");
        }
    }
}
