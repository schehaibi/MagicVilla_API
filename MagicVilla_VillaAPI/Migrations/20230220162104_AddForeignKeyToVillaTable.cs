using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddForeignKeyToVillaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8572), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8589), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 2, 20, 17, 21, 4, 467, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1345), new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1356), new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1358), new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1359), new DateTime(2023, 2, 20, 15, 13, 51, 793, DateTimeKind.Local).AddTicks(1359) });
        }
    }
}
