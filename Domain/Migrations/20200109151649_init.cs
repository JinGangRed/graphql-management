using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class init : Migration
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
                    Name = table.Column<string>(nullable: false),
                    Address_Country = table.Column<string>(nullable: true),
                    Address_Province = table.Column<string>(nullable: true),
                    Address_City = table.Column<string>(nullable: true),
                    Address_Region = table.Column<string>(nullable: true),
                    Address_Street = table.Column<string>(nullable: true),
                    Address_DetailAddress = table.Column<string>(nullable: true),
                    Fix = table.Column<string>(nullable: true)
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
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                name: "Emplyee",
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
                    EmployeeNo = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emplyee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emplyee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emplyee_Department_DepartmentId",
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
                    { 1, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(6654), "825928", "夏协侦", 0, "System" },
                    { 9, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7544), "254041", "张馒", 0, "System" },
                    { 8, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7469), "452702", "祝数韭", 0, "System" },
                    { 7, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7372), "192354", "诸哉", 0, "System" },
                    { 6, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7293), "127584", "郤棕", 0, "System" },
                    { 10, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7640), "847251", "衡精宵", 0, "System" },
                    { 4, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7050), "260953", "嵇雍蝇", 0, "System" },
                    { 3, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(6952), "924850", "房贺", 0, "System" },
                    { 2, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(6868), "833503", "郦烤", 0, "System" },
                    { 5, "System", new DateTime(2020, 1, 9, 23, 16, 48, 848, DateTimeKind.Local).AddTicks(7146), "993529", "钱治酬", 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateBy", "CreateTime", "Name", "NickName", "Password", "Status", "UpdateBy" },
                values: new object[,]
                {
                    { 9, "1179084547", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(2344), "糜袍", "荀窿", "1204786089", 0, "System" },
                    { 1, "475942205", "System", new DateTime(2020, 1, 9, 23, 16, 48, 840, DateTimeKind.Local).AddTicks(6797), "任庐", "霍斧身", "1032206623", 0, "System" },
                    { 2, "201407648", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(718), "施浩", "危巫", "1823036751", 0, "System" },
                    { 3, "1126270651", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(967), "卜橇稼", "卜帝", "1120416200", 0, "System" },
                    { 4, "129812945", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(1186), "别跑窒", "勾隐", "519693159", 0, "System" },
                    { 5, "126127557", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(1477), "诸揭", "桂颂蠕", "628971930", 0, "System" },
                    { 6, "957595547", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(1628), "赵殊", "步旺抒", "1703519036", 0, "System" },
                    { 7, "1631966449", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(1999), "蓝上写", "钮概矛", "1488771521", 0, "System" },
                    { 8, "720710273", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(2183), "汲邯", "成馁捧", "2062638398", 0, "System" },
                    { 10, "750791301", "System", new DateTime(2020, 1, 9, 23, 16, 48, 846, DateTimeKind.Local).AddTicks(2638), "訾添鞘", "韦淀", "2131813845", 0, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartment_CompanyId",
                table: "CompanyDepartment",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplyee_CompanyId",
                table: "Emplyee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Emplyee_DepartmentId",
                table: "Emplyee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDepartment");

            migrationBuilder.DropTable(
                name: "Emplyee");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
