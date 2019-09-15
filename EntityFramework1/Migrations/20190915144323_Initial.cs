using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Studnr = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthdate", "Name", "Studnr" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart", 1001 },
                    { 2, new DateTime(1997, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suzanne", 1002 },
                    { 3, new DateTime(1999, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sam", 1003 },
                    { 4, new DateTime(2001, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inge", 1004 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
