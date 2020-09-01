using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedQuestionsSeedDatatry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Employees_AskingEmployeeID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_AskingEmployeeID",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 792, DateTimeKind.Local).AddTicks(9912), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8649), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8703), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8718), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8731), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8743), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8756), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8770), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8782), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8796), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8809), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8822), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8835), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8849), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8863), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8875), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8889), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8902), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8915), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8928), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8940), new DateTime(2020, 8, 31, 20, 22, 12, 795, DateTimeKind.Local).AddTicks(8943) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 789, DateTimeKind.Local).AddTicks(390), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1182), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1236), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1250), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1262), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1274), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1288), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1301), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1313), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1326), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1338), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1350), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1362), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1374), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1386), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1399), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1412), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1426), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1439), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1452), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1455) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1464), new DateTime(2020, 8, 31, 20, 16, 1, 792, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AskingEmployeeID",
                table: "Questions",
                column: "AskingEmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Employees_AskingEmployeeID",
                table: "Questions",
                column: "AskingEmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
