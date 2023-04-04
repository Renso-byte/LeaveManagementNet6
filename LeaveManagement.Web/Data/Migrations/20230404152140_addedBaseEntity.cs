using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "LeaveTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LeaveAllocationId",
                table: "LeaveAllocations",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveTypes",
                newName: "LeaveTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveAllocations",
                newName: "LeaveAllocationId");
        }
    }
}
