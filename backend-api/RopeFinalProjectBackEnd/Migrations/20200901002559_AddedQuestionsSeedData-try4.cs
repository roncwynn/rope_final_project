using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedQuestionsSeedDatatry4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ReleaseTaskID",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 342, DateTimeKind.Local).AddTicks(6022), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5059), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5116), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5131), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5144), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5157), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5171), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5184), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5197), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5209), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5222), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5235), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5248), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5261), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5274), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5286), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5299), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5312), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5315) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5324), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5327) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5336), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5349), new DateTime(2020, 8, 31, 20, 25, 59, 345, DateTimeKind.Local).AddTicks(5352) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReleaseTaskID",
                table: "Questions",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ReleaseTaskID",
                table: "Questions",
                column: "ReleaseTaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions",
                column: "ReleaseTaskID",
                principalTable: "ReleaseTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
