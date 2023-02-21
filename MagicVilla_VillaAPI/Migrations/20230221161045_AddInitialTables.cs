using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    public partial class AddInitialTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaID = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaID",
                        column: x => x.VillaID,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1709), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa", 4, 200.0, 550, new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1721) },
                    { 2, "", new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1722), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa2", 4, 200.0, 550, new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1723) },
                    { 3, "", new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1724), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa3", 4, 200.0, 550, new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1724) },
                    { 4, "", new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1725), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa4", 4, 200.0, 550, new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1725) },
                    { 5, "", new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1727), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa.jpg", "", "Royal Villa5", 4, 200.0, 550, new DateTime(2023, 2, 21, 17, 10, 44, 826, DateTimeKind.Local).AddTicks(1727) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
