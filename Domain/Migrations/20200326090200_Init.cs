using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 125, nullable: false),
                    Address_Country_Name = table.Column<string>(nullable: true),
                    Address_Country_Address = table.Column<string>(nullable: true),
                    Address_Country_Continent = table.Column<string>(nullable: true),
                    Address_Province = table.Column<string>(maxLength: 25, nullable: true),
                    Address_City = table.Column<string>(maxLength: 25, nullable: true),
                    Address_Region = table.Column<string>(maxLength: 500, nullable: true),
                    Address_Street = table.Column<string>(maxLength: 500, nullable: true),
                    Address_DetailAddress = table.Column<string>(nullable: true),
                    Fix = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DepartmentNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Account = table.Column<string>(maxLength: 10, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDepartment",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDepartment", x => new { x.DepartmentId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_CompanyDepartment_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyDepartment_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    EmployeeNo = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "CreateBy", "CreateTime", "Fix", "Name", "Status", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2020, 3, 26, 17, 2, 0, 282, DateTimeKind.Local).AddTicks(1258), "539855", "宦梦月", 0, "System" },
                    { 2, "System", new DateTime(2020, 3, 26, 17, 2, 0, 282, DateTimeKind.Local).AddTicks(8702), "513756", "平恩宇", 0, "System" },
                    { 3, "System", new DateTime(2020, 3, 26, 17, 2, 0, 283, DateTimeKind.Local).AddTicks(5243), "224060", "和恩蓉", 0, "System" },
                    { 4, "System", new DateTime(2020, 3, 26, 17, 2, 0, 284, DateTimeKind.Local).AddTicks(2700), "123664", "那振淑", 0, "System" },
                    { 5, "System", new DateTime(2020, 3, 26, 17, 2, 0, 285, DateTimeKind.Local).AddTicks(158), "381607", "储婷", 0, "System" },
                    { 6, "System", new DateTime(2020, 3, 26, 17, 2, 0, 285, DateTimeKind.Local).AddTicks(6559), "665295", "葛金", 0, "System" },
                    { 7, "System", new DateTime(2020, 3, 26, 17, 2, 0, 286, DateTimeKind.Local).AddTicks(3415), "360072", "令狐子思", 0, "System" },
                    { 8, "System", new DateTime(2020, 3, 26, 17, 2, 0, 286, DateTimeKind.Local).AddTicks(9878), "584207", "谭钰宇", 0, "System" },
                    { 9, "System", new DateTime(2020, 3, 26, 17, 2, 0, 288, DateTimeKind.Local).AddTicks(356), "590559", "施旭雨", 0, "System" },
                    { 10, "System", new DateTime(2020, 3, 26, 17, 2, 0, 288, DateTimeKind.Local).AddTicks(9418), "501501", "苍淑", 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreateBy", "CreateTime", "DepartmentNo", "Name", "Status", "UpdateBy" },
                values: new object[,]
                {
                    { 9, "System", new DateTime(2020, 3, 26, 17, 2, 0, 297, DateTimeKind.Local).AddTicks(1992), null, "郁晨明", 0, "System" },
                    { 8, "System", new DateTime(2020, 3, 26, 17, 2, 0, 296, DateTimeKind.Local).AddTicks(4824), null, "钮炅", 0, "System" },
                    { 7, "System", new DateTime(2020, 3, 26, 17, 2, 0, 295, DateTimeKind.Local).AddTicks(3008), null, "栾琳海", 0, "System" },
                    { 6, "System", new DateTime(2020, 3, 26, 17, 2, 0, 294, DateTimeKind.Local).AddTicks(5926), null, "巩梓", 0, "System" },
                    { 1, "System", new DateTime(2020, 3, 26, 17, 2, 0, 290, DateTimeKind.Local).AddTicks(9581), null, "马静艺", 0, "System" },
                    { 4, "System", new DateTime(2020, 3, 26, 17, 2, 0, 293, DateTimeKind.Local).AddTicks(2013), null, "巩金承", 0, "System" },
                    { 3, "System", new DateTime(2020, 3, 26, 17, 2, 0, 292, DateTimeKind.Local).AddTicks(5019), null, "夏侯瑞晓", 0, "System" },
                    { 2, "System", new DateTime(2020, 3, 26, 17, 2, 0, 291, DateTimeKind.Local).AddTicks(7997), null, "糜子天", 0, "System" },
                    { 10, "System", new DateTime(2020, 3, 26, 17, 2, 0, 297, DateTimeKind.Local).AddTicks(8798), null, "邰嘉海", 0, "System" },
                    { 5, "System", new DateTime(2020, 3, 26, 17, 2, 0, 293, DateTimeKind.Local).AddTicks(8927), null, "巴紫", 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Account", "CreateBy", "CreateTime", "Name", "NickName", "Password", "Status", "UpdateBy" },
                values: new object[] { 1, "Admin", "System", new DateTime(2020, 3, 26, 17, 2, 0, 148, DateTimeKind.Local).AddTicks(7084), "何骄", "牛明欣", "Admin", 0, "System" });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartment_CompanyId",
                table: "CompanyDepartment",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDepartment");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
