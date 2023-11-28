using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoTownMusicalStore.Migrations
{
    public partial class addSongImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongImage",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongImage",
                table: "Songs");
        }
    }
}
