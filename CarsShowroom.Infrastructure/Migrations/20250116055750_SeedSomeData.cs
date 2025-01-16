using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class SeedSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "Mileage",
                table: "Vehicles",
                type: "int",
                nullable: false,
                comment: "Total distance driven by car up to now",
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldComment: "Total distance driven by car up to now");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Customer identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de", 0, "317342a3-ac1d-459f-98c0-1616794040fc", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEG8BC2nLPy4prlUFYMvjW8mHfqWXmIFroyxm4Nf9S/1MMSPW+94M+cBS9iCzHm/cPQ==", null, false, "5d753f4e-f986-466d-9cce-56f571b9c590", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "Displacement", "EngineType", "Power" },
                values: new object[,]
                {
                    { 1, 3000, 2, 306 },
                    { 2, 2200, 2, 197 },
                    { 3, 2200, 1, 150 }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Hyundai" },
                    { 3, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "DateOfBirth", "Name", "UserId" },
                values: new object[] { 1, "Varna, Pirin Str, 45", new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petar Petrov", "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de" });

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de");

            migrationBuilder.AlterColumn<byte>(
                name: "Mileage",
                table: "Vehicles",
                type: "tinyint",
                nullable: false,
                comment: "Total distance driven by car up to now",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Total distance driven by car up to now");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Customer identifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Customers_CustomerId",
                table: "Vehicles",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
