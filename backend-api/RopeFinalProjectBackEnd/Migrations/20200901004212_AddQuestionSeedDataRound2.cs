using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddQuestionSeedDataRound2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ReleaseTaskID",
                table: "Questions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "IsVisible", "ReleaseTaskID" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "IsVisible", "ReleaseTaskID" },
                values: new object[] { true, 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "IsVisible", "ReleaseTaskID" },
                values: new object[] { true, 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "IsVisible", "ReleaseTaskID" },
                values: new object[] { true, 3 });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 512, DateTimeKind.Local).AddTicks(3476), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5823), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5895), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5910), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5925), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5939), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5953), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5968), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5983), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(5998), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6011), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6027), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6040), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6057), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6072), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6086), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6100), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6115), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6129), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6143), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6147) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6157), new DateTime(2020, 8, 31, 20, 42, 11, 515, DateTimeKind.Local).AddTicks(6161) });

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ReleaseTaskID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ReleaseTaskID",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 889, DateTimeKind.Local).AddTicks(2575), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6363), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6394) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6419), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6434), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6446), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6458), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6470), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6484), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6496), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6508), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6520), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6531), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6543), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6555), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6567), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6579), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6591), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6604), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6617), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6629), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6642), new DateTime(2020, 8, 31, 20, 38, 32, 892, DateTimeKind.Local).AddTicks(6645) });
        }
    }
}
