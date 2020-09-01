using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RopeFinalProjectBackEnd.Migrations
{
    public partial class AddedQuestionsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true),
                    ReleaseTaskID = table.Column<int>(nullable: false),
                    AskingEmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questions_Employees_AskingEmployeeID",
                        column: x => x.AskingEmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_ReleaseTasks_ReleaseTaskID",
                        column: x => x.ReleaseTaskID,
                        principalTable: "ReleaseTasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "ID", "AskingEmployeeID", "QuestionText", "ReleaseTaskID" },
                values: new object[,]
                {
                    { 1, 5, "Will this be complete on time?", 1 },
                    { 2, 5, "Are there any issues?", 1 },
                    { 3, 5, "Are there errors?", 2 },
                    { 4, 5, "Can this be cancelled?", 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ReleaseTaskID",
                table: "Questions",
                column: "ReleaseTaskID");
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
