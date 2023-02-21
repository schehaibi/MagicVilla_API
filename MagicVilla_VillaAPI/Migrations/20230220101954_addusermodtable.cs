using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class addusermodtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Usermod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usermod", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5167), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5170), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4912), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4941), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4943), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4945), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 2, 20, 11, 19, 54, 126, DateTimeKind.Local).AddTicks(4947) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usermod");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2824), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2826), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2827), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2726), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2737), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 2, 20, 11, 0, 59, 333, DateTimeKind.Local).AddTicks(2740) });
        }
    }
}
