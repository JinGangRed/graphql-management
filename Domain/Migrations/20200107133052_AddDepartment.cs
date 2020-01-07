using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class AddDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Emplyee",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1681656358", new DateTime(2020, 1, 7, 21, 30, 51, 923, DateTimeKind.Local).AddTicks(6960), "畅秽慷坍唁唁", "1556965797" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "866916355", new DateTime(2020, 1, 7, 21, 30, 51, 926, DateTimeKind.Local).AddTicks(9446), "儡垦芒攀螟", "1470020148" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "104638315", new DateTime(2020, 1, 7, 21, 30, 51, 926, DateTimeKind.Local).AddTicks(9693), "蝉童洁派斩绽", "1390887340" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "180223172", new DateTime(2020, 1, 7, 21, 30, 51, 926, DateTimeKind.Local).AddTicks(9928), "沂禁傍股碑", "16804466" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "59512981", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(136), "吸狞幕赋枯", "1890504126" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "14396851", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(291), "赚檬煮截猪研", "2056271021" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1456134447", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(460), "仰务倒添俞嘲表", "756802015" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "952004587", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(681), "哮狼庸唇滁柬", "497782678" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "2072819600", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(851), "夷碉困漏出", "961883343" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1416843129", new DateTime(2020, 1, 7, 21, 30, 51, 927, DateTimeKind.Local).AddTicks(1045), "冶科唱午", "1447387428" });

            migrationBuilder.CreateIndex(
                name: "IX_Emplyee_DepartmentId",
                table: "Emplyee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartment_CompanyId",
                table: "CompanyDepartment",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emplyee_Department_DepartmentId",
                table: "Emplyee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emplyee_Department_DepartmentId",
                table: "Emplyee");

            migrationBuilder.DropTable(
                name: "CompanyDepartment");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Emplyee_DepartmentId",
                table: "Emplyee");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Emplyee");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "2009106838", new DateTime(2020, 1, 6, 22, 36, 23, 428, DateTimeKind.Local).AddTicks(6479), "咐只依戊", "943581934" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "2129452747", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6561), "莲拟猪功椿", "2122798020" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1266980299", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6817), "膘喀惑净稻罗", "1405651172" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "857573810", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6993), "绷冬查莆", "544284063" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1940364501", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7212), "众醚滦傀讫疼", "646329307" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "189012032", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7524), "边勿搞谭", "429077688" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1487230545", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7715), "集妹棋怜缉急", "1828771984" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "59688374", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8018), "力谅梁评饰秋", "784235125" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "575397392", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8280), "缀阶以族硝猖彪", "2026557700" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Account", "CreateTime", "NickName", "Password" },
                values: new object[] { "1770183886", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8576), "淋噪悔抚源画律", "45548590" });
        }
    }
}
