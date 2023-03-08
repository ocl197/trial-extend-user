using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trial_extend_user.Data.Migrations
{
    public partial class Farm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farm",
                columns: table => new
                {
                    FarmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farm", x => x.FarmID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FarmId",
                table: "AspNetUsers",
                column: "FarmId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Farm_FarmId",
                table: "AspNetUsers",
                column: "FarmId",
                principalTable: "Farm",
                principalColumn: "FarmID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Farm_FarmId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Farm");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FarmId",
                table: "AspNetUsers");
        }
    }
}
