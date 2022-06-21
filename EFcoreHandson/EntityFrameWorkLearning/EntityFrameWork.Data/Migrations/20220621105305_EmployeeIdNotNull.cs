using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork.Data.Migrations
{
    public partial class EmployeeIdNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "EmployeeEducations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "EmployeeEducations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeEducations_Employees_EmployeeID",
                table: "EmployeeEducations",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID");
        }
    }
}
