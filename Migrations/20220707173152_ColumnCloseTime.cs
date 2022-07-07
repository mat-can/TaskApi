using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.Migrations
{
    public partial class ColumnCloseTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseTime",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 19, 31, 51, 732, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb412"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 19, 31, 51, 732, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb413"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 19, 31, 51, 732, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb414"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 19, 31, 51, 732, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb415"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 19, 31, 51, 732, DateTimeKind.Local).AddTicks(9646));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tasks",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb412"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb413"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb414"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb415"),
                column: "CreateTime",
                value: new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(406));
        }
    }
}
