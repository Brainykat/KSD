using Microsoft.EntityFrameworkCore.Migrations;

namespace KSD.Data.Migrations
{
    public partial class cardno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardNo",
                table: "Students");
        }
    }
}
