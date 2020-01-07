using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class ChangeChineseGenerateRule1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "623306801", new DateTime(2020, 1, 7, 22, 8, 13, 524, DateTimeKind.Local).AddTicks(2752), "沙嵌", "滕 样", "972264640" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1102875294", new DateTime(2020, 1, 7, 22, 8, 13, 529, DateTimeKind.Local).AddTicks(9737), "殷哺攫", "傅 其", "122197059" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1263351210", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(75), "蔚炎瘁", "邹 臼装", "2140270244" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "271858634", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(269), "宇文埂", "魏 掀耀", "737628214" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "801082279", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(435), "游鸣", "衡 珐", "1637160057" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1361782065", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(606), "毛凤", "羿 蕾", "388166285" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "2127501513", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(750), "严滩", "双 高", "762573810" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1686467441", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(936), "空荒", "巫 腆坑", "1037347409" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "1398929570", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(1124), "邓独", "冯 宅", "869681718" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Account", "CreateTime", "Name", "NickName", "Password" },
                values: new object[] { "447450067", new DateTime(2020, 1, 7, 22, 8, 13, 530, DateTimeKind.Local).AddTicks(1331), "阎肛", "刁 经", "2075286181" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
