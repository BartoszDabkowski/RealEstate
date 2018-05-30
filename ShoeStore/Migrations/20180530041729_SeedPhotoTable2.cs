using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedPhotoTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('15.jpg', (SELECT ID FROM Houses WHERE Name = 'Great Family Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('16.jpg', (SELECT ID FROM Houses WHERE Name = 'Awesome Condo!'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('17.jpg', (SELECT ID FROM Houses WHERE Name = 'Perfect for Family'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('18.jpg', (SELECT ID FROM Houses WHERE Name = 'Single Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('19.jpg', (SELECT ID FROM Houses WHERE Name = 'Huge House'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('20.jpg', (SELECT ID FROM Houses WHERE Name = 'Luxury Mansion'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('21.jpg', (SELECT ID FROM Houses WHERE Name = 'Condo for 2'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('22.jpg', (SELECT ID FROM Houses WHERE Name = 'Great Location'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('23.jpg', (SELECT ID FROM Houses WHERE Name = 'Condo Downtown'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('24.jpg', (SELECT ID FROM Houses WHERE Name = 'Downtown Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('25.jpg', (SELECT ID FROM Houses WHERE Name = 'Manufactured Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('26.jpg', (SELECT ID FROM Houses WHERE Name = 'Big Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('27.jpg', (SELECT ID FROM Houses WHERE Name = 'Residential Single Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('28.jpg', (SELECT ID FROM Houses WHERE Name = 'Condo'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('29.jpg', (SELECT ID FROM Houses WHERE Name = 'Great Location'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('30.jpg', (SELECT ID FROM Houses WHERE Name = 'Condo for Family'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('31.jpg', (SELECT ID FROM Houses WHERE Name = 'Huge Condominium'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
