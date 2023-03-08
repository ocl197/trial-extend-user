using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trial_extend_user.Data.Migrations
{
    public partial class farmId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FarmId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FarmId",
                table: "AspNetUsers");
        }
    }
}
