using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Description", "Name", "Weight" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), null, "PersonalStuff", 50 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Description", "Name", "Weight" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), null, "WorkStuff", 20 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "IdTask", "CreateTime", "Description", "IdCategory", "TaskPriorities", "TaskState", "TaskTime", "Title" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"), new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2660), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), 1, 2, 0, "Answer LinkedIn messages" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "IdTask", "CreateTime", "Description", "IdCategory", "TaskPriorities", "TaskState", "TaskTime", "Title" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"), new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2735), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), 1, 2, 0, "Cook lunch" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
