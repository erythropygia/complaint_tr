using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace complaint_tr.Migrations
{
    public partial class initwcomplaint_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    province = table.Column<string>(type: "TEXT", nullable: true),
                    district = table.Column<string>(type: "TEXT", nullable: true),
                    neighbourhood = table.Column<string>(type: "TEXT", nullable: true),
                    longitude = table.Column<float>(type: "REAL", nullable: false),
                    latitude = table.Column<float>(type: "REAL", nullable: false),
                    is_approved = table.Column<bool>(type: "INTEGER", nullable: false),
                    type = table.Column<int>(type: "INTEGER", nullable: false),
                    posting_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    posted_byId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complaints_AspNetUsers_posted_byId",
                        column: x => x.posted_byId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_posted_byId",
                table: "Complaints",
                column: "posted_byId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");
        }
    }
}
