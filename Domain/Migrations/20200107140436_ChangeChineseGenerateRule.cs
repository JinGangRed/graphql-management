using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class ChangeChineseGenerateRule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

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
        }
    }
}
