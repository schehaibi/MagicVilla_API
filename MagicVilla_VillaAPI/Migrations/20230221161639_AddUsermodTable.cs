using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddUsermodTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 2, 21, 17, 16, 38, 833, DateTimeKind.Local).AddTicks(2948) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usermod");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1709), new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1725), new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1727), new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1727) });
        }
    }
}
