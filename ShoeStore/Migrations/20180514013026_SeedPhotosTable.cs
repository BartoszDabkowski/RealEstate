using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedPhotosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('01.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Waterfront View'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('02.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Waterfront View'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('03.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Waterfront View'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('04.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Waterfront View'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('05.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Waterfront View'))");

            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('06.jpg', (SELECT ID FROM Houses WHERE Name = 'Awesome Waterfront View!'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('07.jpg', (SELECT ID FROM Houses WHERE Name = 'The Best Waterfront In Town'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('08.jpg', (SELECT ID FROM Houses WHERE Name = 'Humble Manufactured Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('09.jpg', (SELECT ID FROM Houses WHERE Name = '1 Bedroom Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('10.jpg', (SELECT ID FROM Houses WHERE Name = 'Great For Kids!'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('11.jpg', (SELECT ID FROM Houses WHERE Name = 'Great Price'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('12.jpg', (SELECT ID FROM Houses WHERE Name = 'Great Seattle Location'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('13.jpg', (SELECT ID FROM Houses WHERE Name = 'Beautiful Home'))");
            migrationBuilder.Sql("INSERT INTO Photo (FileName, HouseId) VALUES ('14.jpg', (SELECT ID FROM Houses WHERE Name = 'One of a Kind'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Photo");
        }
    }
}
