using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstate.Migrations
{
    public partial class SeedCountyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT Counties ON");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53001, 'Adams')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53003, 'Asotin')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53005, 'Benton')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53007, 'Chelan')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53009, 'Clallam')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53011, 'Clark')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53013, 'Columbia')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53015, 'Cowlitz')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53017, 'Douglas')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53019, 'Ferry')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53021, 'Franklin')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53023, 'Garfield')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53025, 'Grant')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53027, 'Grays Harbor')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53029, 'Island')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53031, 'Jefferson')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53033, 'King')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53035, 'Kitsap')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53037, 'Kittitas')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53039, 'Klickitat')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53041, 'Lewis')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53043, 'Lincoln')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53045, 'Mason')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53047, 'Okanogan')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53049, 'Pacific')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53051, 'Pend Oreille')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53053, 'Pierce')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53055, 'San Juan')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53057, 'Skagit')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53059, 'Skamania')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53061, 'Snohomish')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53063, 'Spokane')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53065, 'Stevens')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53067, 'Thurston')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53069, 'Wahkiakum')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53071, 'Walla Walla')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53073, 'Whatcom')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53075, 'Whitman')");
            migrationBuilder.Sql("INSERT INTO Counties (Id, Name) VALUES (53077, 'Yakima')");
            migrationBuilder.Sql("SET IDENTITY_INSERT Counties OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Counties");
        }
    }
}
