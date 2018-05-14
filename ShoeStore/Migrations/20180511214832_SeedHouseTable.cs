using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedHouseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.5, 2, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 1, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.928934, -122.091729, 'Beautiful Waterfront View', 800000.00, 3500, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '23413 13th St Se', 98290)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Houses");
        }
    }
}
