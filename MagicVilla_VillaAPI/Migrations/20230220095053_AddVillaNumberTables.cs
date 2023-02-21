using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddVillaNumberTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillasNumber",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5309), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5310), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5312), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5314), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5554), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5555), new DateTime(2023, 2, 20, 10, 50, 53, 445, DateTimeKind.Local).AddTicks(5555) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillasNumber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1942), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1952), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1954), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1956), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2062), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "VillasNumber",
                keyColumn: "VillaNo",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2064), new DateTime(2023, 2, 20, 10, 37, 24, 338, DateTimeKind.Local).AddTicks(2064) });
        }
    }
}
