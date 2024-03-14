using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeSyncMVCWebApp.Data.Migrations
{
    public partial class DatabaseSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c683a83b-82a9-4436-af59-0b980068a995"), 0, "178be58d-249e-4fa3-8f56-3f3e48363db6", null, false, false, null, null, null, null, null, false, null, false, null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "DateCreated", "Deadline", "Description", "Name", "Status", "UserId" },
                values: new object[] { 1, new DateTime(2024, 3, 14, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2181), new DateTime(2024, 4, 14, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2134), "This is a sample project", "Project Alpha", 0, new Guid("c683a83b-82a9-4436-af59-0b980068a995") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "DateCreated", "Deadline", "Description", "Priority", "ProjectId", "Status", "Title", "UserId" },
                values: new object[] { 1, new DateTime(2024, 3, 14, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 3, 29, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2217), "This is a sample task for Project Alpha", 1, 1, 0, "Task 1", new Guid("c683a83b-82a9-4436-af59-0b980068a995") });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "DateCreated", "Deadline", "Description", "Priority", "ProjectId", "Status", "Title", "UserId" },
                values: new object[] { 2, new DateTime(2024, 3, 14, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 3, 29, 17, 42, 31, 610, DateTimeKind.Local).AddTicks(2227), "This is a sample task222 for Project Alpha", 0, 1, 2, "Task 2", new Guid("c683a83b-82a9-4436-af59-0b980068a995") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c683a83b-82a9-4436-af59-0b980068a995"));
        }
    }
}
