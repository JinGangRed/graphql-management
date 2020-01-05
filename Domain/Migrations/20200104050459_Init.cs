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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    UpdateTime = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(nullable: true),
                    Account = table.Column<string>(maxLength: 10, nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false),
                    NickName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateBy", "CreateTime", "NickName", "Password", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "523196861", "System", new DateTime(2020, 1, 4, 13, 4, 59, 462, DateTimeKind.Local).AddTicks(3535), "雾曝政枢蘸磅副", "1258548587", "System" },
                    { 2, "455504138", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(778), "赢豌谎案", "936210315", "System" },
                    { 3, "450630276", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1041), "霸缆栓迂扰哈", "776343471", "System" },
                    { 4, "1566124266", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1214), "蓄侍婆诡瓷", "1895261234", "System" },
                    { 5, "386221349", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1365), "淑袖故尘档球佐", "1217328392", "System" },
                    { 6, "1287529653", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1593), "揉背尼茹掇裸", "66281381", "System" },
                    { 7, "1173567503", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1764), "嫂坞臃踩怔描", "2097303359", "System" },
                    { 8, "564027261", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1966), "炕榨柿羚悠", "1955453838", "System" },
                    { 9, "228721031", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2115), "矣伏钱平", "150803890", "System" },
                    { 10, "922075987", "System", new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2245), "很瑶泼龋狰", "19990018", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
