using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace restful_api.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cricket",
                columns: table => new
                {
                    CricketerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CrickterName = table.Column<string>(type: "text", nullable: false),
                    JerseyNumber = table.Column<int>(type: "integer", nullable: false),
                    Matches = table.Column<int>(type: "integer", nullable: false),
                    Runs = table.Column<int>(type: "integer", nullable: false),
                    Wickets = table.Column<int>(type: "integer", nullable: false),
                    BowlingAvg = table.Column<double>(type: "double precision", nullable: false),
                    BattingAvg = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cricket", x => x.CricketerId);
                });

            migrationBuilder.CreateTable(
                name: "Hockey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    JerseyNumber = table.Column<int>(type: "integer", nullable: false),
                    Apperance = table.Column<int>(type: "integer", nullable: false),
                    Goals = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hockey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soccer",
                columns: table => new
                {
                    FootballerId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FootballerName = table.Column<string>(type: "text", nullable: false),
                    JerseyNumber = table.Column<int>(type: "integer", nullable: false),
                    Matches = table.Column<int>(type: "integer", nullable: false),
                    Goals = table.Column<int>(type: "integer", nullable: false),
                    Assist = table.Column<int>(type: "integer", nullable: false),
                    YellowCard = table.Column<int>(type: "integer", nullable: false),
                    RedCard = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soccer", x => x.FootballerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cricket");

            migrationBuilder.DropTable(
                name: "Hockey");

            migrationBuilder.DropTable(
                name: "Soccer");
        }
    }
}
