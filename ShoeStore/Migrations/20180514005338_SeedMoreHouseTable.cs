using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Migrations
{
    public partial class SeedMoreHouseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Cities (Name, CountyId) VALUES ('Seattle', 53033)");


            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (1, 3, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 1, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.933730, -122.091643, 'Awesome Waterfront View!', 975000.00, 3000, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '15785 45th St Ne', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (1.1, 2, 3, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        1, 1, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.933036, -122.098336, 'The Best Waterfront In Town', 678000.00, 2000, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '67345 122nd St Sw', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.25, 1, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.918226, -122.090426, 'Humble Manufactured Home', 250000.00, 1500, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '4567 14th Pl Sw', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.15, 1, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.921574, -122.089312, '1 Bedroom Home', 150000.00, 1000, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '225 Johnson Pl Ne', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.35, 1, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Manufacturd Home'), 
                                        47.927027, -122.080299, 'Great For Kids!', 150000.00, 1000, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '24590 Ford Ave Sw', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.45, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.930328, -122.084533, 'Great Price', 179000.00, 1500, 
                                        (SELECT ID FROM Cities WHERE Name = 'Snohomish'), 
                                        '5678 15th St Sw', 98290)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.15, 2, 1, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.65422, -122.280989, 'Great Seattle Location', 850000.00, 750, 
                                        (SELECT ID FROM Cities WHERE Name = 'Seattle'), 
                                        '24590 43rd Ave Ne', 98105)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.50, 3, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.631185, -122.286941, 'Beautiful Home', 975000.00, 1550, 
                                        (SELECT ID FROM Cities WHERE Name = 'Seattle'), 
                                        '32890 Broadmoor Dr E', 98105)");

            migrationBuilder.Sql(@"INSERT INTO Houses (Acres, Bathrooms, Bedrooms, Description, HasView, HasWaterfront, HouseTypeId, 
                                    Latitude, Longitude, Name, Price, SquareFootage, Address_CityId, Address_Street, Address_ZipCode) 
                                VALUES (0.15, 3, 2, 
                                        'Lorem ipsum dolor sit amet, eu eam omittam electram definitiones, pro mazim oratio definitionem te. In nam prompta luptatum. Per ei hinc inani erroribus. Falli suscipit at sea, usu in putant incorrupte. Ubique senserit eu eos, percipit efficiendi an mei. Est eruditi alienum perpetua et, duo eu choro quodsi. Harum virtute at vis. Duo cetero laoreet at, sea error nostrum moderatius id. Possim euripidis has ea, mea dicit legere an. Sit ut enim verterem pericula, ad dicant ignota prodesset usu, vel ad aeque nemore petentium. Ex sed meis congue definitionem, eum mazim molestie at.',
                                        0, 0, 
                                        (SELECT ID FROM HouseType WHERE Name = 'Residential Single'), 
                                        47.577757, -122.285408, 'One of a Kind', 870000.00, 2500, 
                                        (SELECT ID FROM Cities WHERE Name = 'Seattle'), 
                                        '6789 Cascadia Ave S', 98105)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Houses");
            migrationBuilder.Sql(@"DELETE FROM Cities WHERE Id ='Seattle'");
        }
    }
}
