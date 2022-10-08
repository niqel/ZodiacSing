using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZodiacSign.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    updatedBy = table.Column<int>(type: "int", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Element", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Gem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    updatedBy = table.Column<int>(type: "int", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gem", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    updatedBy = table.Column<int>(type: "int", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sign",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fromMonth = table.Column<int>(type: "int", nullable: false),
                    fromDay = table.Column<int>(type: "int", nullable: false),
                    untilMonth = table.Column<int>(type: "int", nullable: false),
                    untilDay = table.Column<int>(type: "int", nullable: false),
                    elementId = table.Column<int>(type: "int", nullable: false),
                    gemId = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<int>(type: "int", nullable: false),
                    createdAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sign", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sign_Element_elementId",
                        column: x => x.elementId,
                        principalTable: "Element",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sign_Gem_gemId",
                        column: x => x.gemId,
                        principalTable: "Gem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignHome",
                columns: table => new
                {
                    signId = table.Column<int>(type: "int", nullable: false),
                    homeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignHome", x => new { x.signId, x.homeId });
                    table.ForeignKey(
                        name: "FK_SignHome_Home_homeId",
                        column: x => x.homeId,
                        principalTable: "Home",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SignHome_Sign_signId",
                        column: x => x.signId,
                        principalTable: "Sign",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Element",
                columns: new[] { "id", "createdAt", "createdBy", "isActive", "name", "updatedAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8626), -1, true, "Air (mutable)", new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8660), -1 },
                    { 2, new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8663), -1, true, "Earth (fixed)", new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8664), -1 },
                    { 3, new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8666), -1, true, "fire (cardinal)", new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8668), -1 },
                    { 4, new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8670), -1, true, "water (cardinal)", new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8671), -1 }
                });

            migrationBuilder.InsertData(
                table: "Gem",
                columns: new[] { "id", "createdAt", "createdBy", "isActive", "name", "updatedAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(433), -1, true, "Amber", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(444), -1 },
                    { 2, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(447), -1, true, "Amethyst", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(448), -1 },
                    { 3, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(450), -1, true, "Aquamarine", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(452), -1 },
                    { 4, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(453), -1, true, "Diamond", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(455), -1 },
                    { 5, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(457), -1, true, "Emerald", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(458), -1 },
                    { 6, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(460), -1, true, "Garnet", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(461), -1 },
                    { 7, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(463), -1, true, "Opal", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(465), -1 },
                    { 8, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(466), -1, true, "Pearl", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(468), -1 },
                    { 9, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(470), -1, true, "Ruby", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(471), -1 },
                    { 10, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(473), -1, true, "Sapphire", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(474), -1 },
                    { 11, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(476), -1, true, "Topaz", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(477), -1 },
                    { 12, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(479), -1, true, "Turquoise", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(481), -1 }
                });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "id", "createdAt", "createdBy", "isActive", "name", "updatedAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1507), -1, true, "Jupiter", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1516), -1 },
                    { 2, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1518), -1, true, "Land", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1520), -1 },
                    { 3, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1522), -1, true, "Mars", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1523), -1 },
                    { 4, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1525), -1, true, "Mercury", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1526), -1 },
                    { 5, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1528), -1, true, "Moon", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1529), -1 },
                    { 6, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1531), -1, true, "Neptune", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1533), -1 },
                    { 7, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1534), -1, true, "Pluto", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1536), -1 },
                    { 8, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1537), -1, true, "Saturn", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1539), -1 },
                    { 9, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1541), -1, true, "Sun", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1543), -1 },
                    { 10, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1544), -1, true, "Uranus", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1546), -1 },
                    { 11, new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1548), -1, true, "Venus", new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1549), -1 }
                });

            migrationBuilder.InsertData(
                table: "Sign",
                columns: new[] { "id", "createdAt", "createdBy", "elementId", "fromDay", "fromMonth", "gemId", "isActive", "name", "untilDay", "untilMonth", "updatedAt", "updatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8456), -1, 3, 21, 3, 9, true, "Aries", 20, 4, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8471), -1 },
                    { 2, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8475), -1, 2, 21, 4, 5, true, "Taurus", 20, 5, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8477), -1 },
                    { 3, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8479), -1, 1, 21, 5, 8, true, "Gemini", 21, 6, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8481), -1 },
                    { 4, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8483), -1, 4, 22, 6, 4, true, "Cancer", 22, 7, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8484), -1 },
                    { 5, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8486), -1, 3, 23, 7, 1, true, "Leo", 23, 8, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8487), -1 },
                    { 6, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8489), -1, 2, 24, 8, 10, true, "Virgo", 23, 9, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8491), -1 },
                    { 7, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8493), -1, 1, 24, 9, 7, true, "Libra", 22, 10, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8496), -1 },
                    { 8, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8498), -1, 1, 23, 10, 11, true, "Scorpio", 22, 11, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8500), -1 },
                    { 9, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8502), -1, 2, 23, 11, 11, true, "Sagittarius", 21, 12, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8503), -1 },
                    { 10, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8505), -1, 2, 22, 12, 6, true, "Capricorn", 20, 1, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8506), -1 },
                    { 11, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8508), -1, 1, 21, 1, 2, true, "Aquarium", 20, 2, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8509), -1 },
                    { 12, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8511), -1, 1, 21, 2, 3, true, "Pisces", 20, 3, new DateTime(2022, 7, 14, 4, 20, 4, 490, DateTimeKind.Local).AddTicks(8513), -1 }
                });

            migrationBuilder.InsertData(
                table: "SignHome",
                columns: new[] { "homeId", "signId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 7, 1 },
                    { 2, 2 },
                    { 11, 2 },
                    { 3, 3 },
                    { 5, 4 },
                    { 9, 5 },
                    { 3, 6 },
                    { 11, 7 },
                    { 3, 8 },
                    { 7, 8 },
                    { 1, 9 },
                    { 8, 10 },
                    { 8, 11 },
                    { 10, 11 },
                    { 1, 12 },
                    { 6, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sign_elementId",
                table: "Sign",
                column: "elementId");

            migrationBuilder.CreateIndex(
                name: "IX_Sign_gemId",
                table: "Sign",
                column: "gemId");

            migrationBuilder.CreateIndex(
                name: "IX_SignHome_homeId",
                table: "SignHome",
                column: "homeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SignHome");

            migrationBuilder.DropTable(
                name: "Home");

            migrationBuilder.DropTable(
                name: "Sign");

            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "Gem");
        }
    }
}
