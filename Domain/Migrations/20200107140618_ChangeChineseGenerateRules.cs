using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class ChangeChineseGenerateRules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1065970980", new DateTime(2020, 1, 7, 22, 6, 17, 782, DateTimeKind.Local).AddTicks(2541), "韩 酥", "闵 松荷", "1715516260" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "912083853", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1204), "米 循", "令狐 还", "2110850260" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "2122574946", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1458), "边 的", "钭 膜愤", "656653544" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "716017819", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1678), "郦 炒", "糜 灰", "1395862892" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1812268470", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1829), "万俟 觉善", "边 风", "1383087770" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "483393011", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(1996), "常 骆", "蔺 顾羌", "710706611" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "134625408", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2199), "蓝 生", "扈 谨毛", "874642833" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "773083816", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2361), "郝 涸萧", "融 吮掺", "1126919246" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1806051293", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2573), "雍 来新", "经 侦", "1135347123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "473509110", new DateTime(2020, 1, 7, 22, 6, 17, 788, DateTimeKind.Local).AddTicks(2737), "周 蹬曳", "欧阳 狈期", "1740400667" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1201161703", new DateTime(2020, 1, 7, 22, 4, 35, 676, DateTimeKind.Local).AddTicks(604), "确绽 和", "纫汕 从", "633572060" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "630371293", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(1095), "霖 顾", "盖 柳", "2108446783" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1539791011", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(1465), "粮 弓", "魂 韩", "690030426" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "188263780", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(1621), "陵 平", "亭每 谢", "122540178" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "418570974", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(1784), "苟环 乜", "亚 应", "768661316" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1784875099", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(1991), "扶 艾", "悯返 郁", "173460992" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1207163403", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(2156), "汉芳 於", "做闭 巢", "823112832" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1981781499", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(2380), "少肠 葛", "穗评 尚", "985820694" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "97963185", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(2561), "怕 危", "搪泳 柏", "342857797" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1279784390", new DateTime(2020, 1, 7, 22, 4, 35, 686, DateTimeKind.Local).AddTicks(2720), "嫌 东方", "岸 尤", "427343144" });
        }
    }
}
