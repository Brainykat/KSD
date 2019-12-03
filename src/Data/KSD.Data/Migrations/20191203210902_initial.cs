using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KSD.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SMSLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    msisdn = table.Column<string>(maxLength: 15, nullable: false),
                    Message = table.Column<string>(maxLength: 160, nullable: false),
                    IsSent = table.Column<bool>(nullable: false),
                    IsDelivered = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name_Sur = table.Column<string>(maxLength: 50, nullable: true),
                    Name_First = table.Column<string>(maxLength: 50, nullable: true),
                    Name_Middle = table.Column<string>(maxLength: 50, nullable: true, defaultValue: ""),
                    AdmissionNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Grade = table.Column<string>(maxLength: 12, nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<Guid>(nullable: false),
                    MealType = table.Column<int>(nullable: false),
                    POSId = table.Column<long>(nullable: false),
                    IsServed = table.Column<bool>(nullable: false),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    ServiceTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meal_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    Name_Sur = table.Column<string>(maxLength: 50, nullable: true),
                    Name_First = table.Column<string>(maxLength: 50, nullable: true),
                    Name_Middle = table.Column<string>(maxLength: 50, nullable: true, defaultValue: ""),
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    Phone2 = table.Column<string>(maxLength: 12, nullable: true),
                    PhysicalLocation = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parent_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meal_StudentId",
                table: "Meal",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_StudentId",
                table: "Parent",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "SMSLogs");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
