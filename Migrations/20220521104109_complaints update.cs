using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace complaint_tr.Migrations
{
    public partial class complaintsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "second_line",
                table: "Complaints",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "second_line",
                table: "Complaints");
        }
    }
}
