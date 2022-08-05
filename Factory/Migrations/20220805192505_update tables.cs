using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineer_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machine_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machine",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer");

            migrationBuilder.RenameTable(
                name: "Machine",
                newName: "Machines");

            migrationBuilder.RenameTable(
                name: "Engineer",
                newName: "Engineers");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "License",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machines",
                table: "Machines",
                column: "MachineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers",
                column: "EngineerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Engineers_EngineerId",
                table: "EngineerMachine");

            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machines",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "License",
                table: "Engineers");

            migrationBuilder.RenameTable(
                name: "Machines",
                newName: "Machine");

            migrationBuilder.RenameTable(
                name: "Engineers",
                newName: "Engineer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machine",
                table: "Machine",
                column: "MachineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer",
                column: "EngineerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Engineer_EngineerId",
                table: "EngineerMachine",
                column: "EngineerId",
                principalTable: "Engineer",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machine_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
