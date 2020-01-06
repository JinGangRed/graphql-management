using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class InitUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Account", "CreateBy", "CreateTime", "NickName", "Password", "Status", "UpdateBy" },
                values: new object[,]
                {
                    { 1, "2009106838", "System", new DateTime(2020, 1, 6, 22, 36, 23, 428, DateTimeKind.Local).AddTicks(6479), "咐只依戊", "943581934", 0, "System" },
                    { 2, "2129452747", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6561), "莲拟猪功椿", "2122798020", 0, "System" },
                    { 3, "1266980299", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6817), "膘喀惑净稻罗", "1405651172", 0, "System" },
                    { 4, "857573810", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(6993), "绷冬查莆", "544284063", 0, "System" },
                    { 5, "1940364501", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7212), "众醚滦傀讫疼", "646329307", 0, "System" },
                    { 6, "189012032", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7524), "边勿搞谭", "429077688", 0, "System" },
                    { 7, "1487230545", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(7715), "集妹棋怜缉急", "1828771984", 0, "System" },
                    { 8, "59688374", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8018), "力谅梁评饰秋", "784235125", 0, "System" },
                    { 9, "575397392", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8280), "缀阶以族硝猖彪", "2026557700", 0, "System" },
                    { 10, "1770183886", "System", new DateTime(2020, 1, 6, 22, 36, 23, 436, DateTimeKind.Local).AddTicks(8576), "淋噪悔抚源画律", "45548590", 0, "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
