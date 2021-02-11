using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDatabase.Migrations
{
    public partial class MovieDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    MovieImg = table.Column<string>(nullable: true),
                    MovieURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");
        }
    }
}
