using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SafetyRequests.Migrations
{
    public partial class SeedRolesandDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns:new [] {"Id", "DepartmentName", "Idn", "CreatedDate", "LastModifiedDate" },
                values: new object[] { "101450a2-7d2c-49be-8a5a-59105b69dcae","HR",1,DateTime.Now, DateTime.Now }
                );
            migrationBuilder.InsertData(
               table: "Departments",
               columns: new[] { "Id", "DepartmentName", "Idn", "CreatedDate", "LastModifiedDate" },
               values: new object[] { "64a2a1b0-5c41-4625-8fea-4cffde06fd0e", "Finacial", 2, DateTime.Now, DateTime.Now }
               );
            migrationBuilder.InsertData(
               table: "Departments",
               columns: new[] { "Id", "DepartmentName", "Idn", "CreatedDate", "LastModifiedDate" },
               values: new object[] { "64a2a1b0-5c41-4625-8fea-4cffde06fdea", "Operation", 3, DateTime.Now, DateTime.Now }
               );
            migrationBuilder.InsertData(
               table: "Departments",
               columns: new[] { "Id", "DepartmentName", "Idn", "CreatedDate", "LastModifiedDate" },
               values: new object[] { "101450a2-7d2c-50be-8a5a-59105b69dcae", "Legal", 4, DateTime.Now, DateTime.Now }
               );

            migrationBuilder.InsertData(
                table: "EmployeeRoles",
                columns: new[] { "Id", "RoleNqme", "Idn", "CreatedDate", "LastModifiedDate" },
                 values: new object[] { "511c351e-02c4-4a13-9eac-99fb53f0e8d6", "Admin", 1, DateTime.Now, DateTime.Now }
                );
            migrationBuilder.InsertData(
                table: "EmployeeRoles",
                columns: new[] { "Id", "RoleNqme", "Idn", "CreatedDate", "LastModifiedDate" },
                 values: new object[] { "30880436-bf25-4989-a945-2544d79d8ad0", "SuperVisor", 1, DateTime.Now, DateTime.Now }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[EmployeeRoles]");
            migrationBuilder.Sql("DELETE FROM [dbo].[Departments]");
        }
    }
}
