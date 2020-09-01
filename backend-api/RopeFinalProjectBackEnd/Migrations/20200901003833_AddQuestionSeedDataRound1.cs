using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddQuestionSeedDataRound1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "ID", "QuestionText" },
                values: new object[,]
                {
                    { 1, "Will this be complete on time?" },
                    { 2, "Are there any issues?" },
                    { 3, "Are there errors?" },
                    { 4, "Can this be cancelled?" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 537, DateTimeKind.Local).AddTicks(338), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3803), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3859), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3876), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3884), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3897), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3910), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3923), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3936), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3944), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3957), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3970), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3978), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3991), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4004), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4013), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4025), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4038), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4047), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4060), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "ReleaseTasks",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4072), new DateTime(2020, 8, 12, 20, 13, 54, 539, DateTimeKind.Local).AddTicks(4072) });
        }
    }
}
