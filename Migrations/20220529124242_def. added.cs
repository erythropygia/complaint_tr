using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace complaint_tr.Migrations
{
    public partial class defadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "definition",
                table: "Complaints",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "definition",
                table: "Complaints");
        }
    }
}
