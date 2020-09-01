using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedQuestionsSeedDatatry3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AskingEmployeeID",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseTaskID",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                column: "ReleaseTaskID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                column: "ReleaseTaskID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                column: "ReleaseTaskID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4,
                column: "ReleaseTaskID",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 837, DateTimeKind.Local).AddTicks(3799), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1724), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1828), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1844), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1857), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1869), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1883), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1895), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1908), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1920), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1934), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1947), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1959), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1972), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1985), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1997), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2010), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2026), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2042), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2055), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2068), new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions",
                column: "ReleaseTaskID",
                principalTable: "ReleaseTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseTaskID",
                table: "Questions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AskingEmployeeID",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AskingEmployeeID", "ReleaseTaskID" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AskingEmployeeID", "ReleaseTaskID" },
                values: new object[] { 5, 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AskingEmployeeID", "ReleaseTaskID" },
                values: new object[] { 5, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "AskingEmployeeID", "ReleaseTaskID" },
                values: new object[] { 5, 3 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions",
                column: "ReleaseTaskID",
                principalTable: "ReleaseTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
