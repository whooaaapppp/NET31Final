using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoShop.EFDataAcccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Borrower",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Borrower_Name = table.Column<string>(nullable: true),
                    Date_of_Birth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrower", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Video_Title = table.Column<string>(nullable: true),
                    Release_Date = table.Column<DateTime>(nullable: false),
                    Borrower_ID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Video_Borrower_Borrower_ID",
                        column: x => x.Borrower_ID,
                        principalTable: "Borrower",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Video_Borrower_ID",
                table: "Video",
                column: "Borrower_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Borrower");
        }
    }
}
