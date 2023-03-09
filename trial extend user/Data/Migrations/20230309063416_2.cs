using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace trial_extend_user.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FarmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubscriptionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Farms_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Farms",
                columns: new[] { "ID", "ApplicationUserId", "FarmName", "OwnerId", "SubscriptionStatus" },
                values: new object[] { 1, null, "Olivers Farm", "2b9659af-daee-4b19-9678-6249fc5f9a42", "Paid" });

            migrationBuilder.CreateIndex(
                name: "IX_Farms_ApplicationUserId",
                table: "Farms",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farms");
        }
    }
}
