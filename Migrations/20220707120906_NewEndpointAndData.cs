using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskApi.Migrations
{
    public partial class NewEndpointAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                column: "Weight",
                value: 50);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Description", "Name", "Weight" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb448"), null, "HobbieStuff", 50 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                columns: new[] { "CreateTime", "TaskTime" },
                values: new object[] { new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(356), 5 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "IdTask", "CreateTime", "Description", "IdCategory", "TaskPriorities", "TaskState", "TaskTime", "Title" },
                values: new object[,]
                {
                    { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb412"), new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(397), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), 1, 2, 40, "Cook lunch" },
                    { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb413"), new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(400), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), 0, 0, 0, "Sweep kitchen floor" },
                    { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb415"), new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(406), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"), 2, 0, 0, "Pay health ensurance" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "IdTask", "CreateTime", "Description", "IdCategory", "TaskPriorities", "TaskState", "TaskTime", "Title" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb414"), new DateTime(2022, 7, 7, 14, 9, 5, 824, DateTimeKind.Local).AddTicks(403), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb448"), 1, 1, 0, "Finish shingeki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb412"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb413"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb414"));

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb415"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb448"));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                column: "Weight",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "IdTask",
                keyValue: new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                columns: new[] { "CreateTime", "TaskTime" },
                values: new object[] { new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2660), 0 });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "IdTask", "CreateTime", "Description", "IdCategory", "TaskPriorities", "TaskState", "TaskTime", "Title" },
                values: new object[] { new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"), new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2735), null, new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"), 1, 2, 0, "Cook lunch" });
        }
    }
}
