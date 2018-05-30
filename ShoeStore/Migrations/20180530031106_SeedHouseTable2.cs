using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealEstate.Migrations
{
    public partial class SeedHouseTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Clearview
            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.4, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.840830, -122.118545, 'Great Family Home', 358000.00, 2000, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '2367 42nd Ave Sw', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.35, 2, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.844340, -122.114618, 'Awesome Condo!', 277000.00, 1025, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '1234 12th St Ne', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.65, 1, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.844340, -122.114618, 'Perfect for Family', 125000.00, 870, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '674 E Interurban Blvd', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.25, 1, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.840285, -122.112383, 'Single Home', 185000.00, 500, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '3467 172nd St Se', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.87, 4, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.841256, -122.108948, 'Huge House', 850000.00, 2565, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '2367 172nd St Se', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (1.2, 4, 4, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.844515, -122.114741, 'Luxury Mansion', 999000.00, 3125, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '908 87th Ave Se', 98296)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.15, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.844873, -122.118144, 'Condo for 2', 275000.00, 1145, 
                                        (SELECT ID FROM Cities WHERE Name = 'Clearview'), 
                                        '567 168th St Se', 98296)");

            // Everett
            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.05, 1, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.975126, -122.203205, 'Great Location', 175000.00, 540, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '345 Lombard Ave', 98201)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.25, 2, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.975419, -122.205200, 'Condo Downtown', 455000.00, 1750, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '123 32nd St Ne', 98201)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.34, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.984301, -122.198271, 'Downtown Home', 375000.00, 1450, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '567 25th St Sw', 98201)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.36, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.983851, -122.196370, 'Manufactured Home', 125000.00, 900, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '39764 BlaKe Ave', 98201)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.50, 3, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.985201, -122.194759, 'Big Home', 460000.00, 1900, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '3570 Fulton St', 98201)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.66, 4, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.985950, -122.198268, 'Residential Single Home', 568000.00, 1600, 
                                        (SELECT ID FROM Cities WHERE Name = 'Everett'), 
                                        '985 Rainier Ave', 98201)");

            // Snohomish
            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.66, 4, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.925619, -122.095156, 'Condo', 446000.00, 1400, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '4689 Avenue B', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.15, 1, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.924233, -122.092887, 'Great Location!', 256000.00, 600, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '876 10th St', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.2, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.935663, -122.082596, 'Condo for Family', 175000.00, 1200, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '5478 Terrace Ave', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (.2, 3, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Condominium'), 
                                        47.920498, -122.096317, 'Huge Condominium', 445000.00, 1760, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '5478 Ave C E', 98290)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //TODO: add Down migration
        }
    }
}
