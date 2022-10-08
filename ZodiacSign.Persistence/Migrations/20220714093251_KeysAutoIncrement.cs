using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZodiacSign.Persistence.Migrations
{
    public partial class KeysAutoIncrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SignHome",
                table: "SignHome");

            migrationBuilder.DropIndex(
                name: "IX_SignHome_homeId",
                table: "SignHome");

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 9, 5 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 11, 7 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 8, 11 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "SignHome",
                keyColumns: new[] { "homeId", "signId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sign",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Sign",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Home",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Gem",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Element",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignHome",
                table: "SignHome",
                columns: new[] { "homeId", "signId" });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6606), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6639), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6641) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6643), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6646), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7655), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7659), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7662), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7666), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7669), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7671) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7673), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8557), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8612), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8613) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8615), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8619), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8622), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8626), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8629), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8633), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8636), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 14, 4, 32, 50, 789, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.CreateIndex(
                name: "IX_SignHome_signId",
                table: "SignHome",
                column: "signId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SignHome",
                table: "SignHome");

            migrationBuilder.DropIndex(
                name: "IX_SignHome_signId",
                table: "SignHome");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Sign",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Home",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Gem",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Element",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SignHome",
                table: "SignHome",
                columns: new[] { "signId", "homeId" });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8626), new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8663), new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Element",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 14, 4, 20, 4, 488, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(447), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(453), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(473), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(476), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Gem",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(479), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1507), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1522), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1525), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1531), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1537), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1541), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1544), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "createdAt", "updatedAt" },
                values: new object[] { new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 7, 14, 4, 20, 4, 489, DateTimeKind.Local).AddTicks(1549) });

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
                name: "IX_SignHome_homeId",
                table: "SignHome",
                column: "homeId");
        }
    }
}
