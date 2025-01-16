using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsShowroom.Infrastructure.Migrations
{
    public partial class VehiclesDataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YearOfProduction",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Vehicle production year",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldComment: "Vehicle production year");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Settlement where vehicle is",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Settlement where vehicle is");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Vehicle model",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Vehicle model");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehicles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Vehicle color",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "Vehicle color");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "999f28ae-e3d7-496b-8f58-7cadef280bc2", "AQAAAAEAACcQAAAAEKqtLe+8GrmqrjdUCXugnBNcjLdlYPKiTlkidzOKyDh9EUNiAT70fN5q15C5EZUQvQ==", "934fba33-6412-4a1f-9809-3f46017456be" });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "CustomerId", "EngineId", "Features", "Gearbox", "ImageUrl", "ManufacturerId", "Mileage", "Model", "Price", "Region", "YearOfProduction" },
                values: new object[,]
                {
                    { 1, "Black", 1, 1, 1, "4x4, ABS, ESP, Airbag, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Центр. заключване, Старт-Стоп система, Безключово палене", 3, "https://automoto.bg/listings/media/listing//1709991365_nis5vfph.jpg", 1, 178000, "X5 3.5i Xdrive", 41500.00m, "Plovdiv", "2016" },
                    { 2, "Grey metalic", 1, 1, 2, "4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка, Старт-Стоп система, Безключово палене", 2, "https://automoto.bg/listings/media/listing//1720295931_img-209442bc4babdf576e0cf1740ae33342-v.jpg", 2, 174000, "Santa Fe 2.2CRDI - 4WD", 34000.00m, "Lovech", "2014" },
                    { 3, "Red", 2, 1, 3, "  4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка", 1, "https://automoto.bg/listings/media/listing//1725859766_uml1.jpg", 3, 209000, "Honda CR-V 2.2", 19000.00m, "Smolyan", "2011" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfProduction",
                table: "Vehicles",
                type: "datetime2",
                nullable: false,
                comment: "Vehicle production year",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Vehicle production year");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Vehicles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Settlement where vehicle is",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Settlement where vehicle is");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Vehicle model",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Vehicle model");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                comment: "Vehicle color",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Vehicle color");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "317342a3-ac1d-459f-98c0-1616794040fc", "AQAAAAEAACcQAAAAEG8BC2nLPy4prlUFYMvjW8mHfqWXmIFroyxm4Nf9S/1MMSPW+94M+cBS9iCzHm/cPQ==", "5d753f4e-f986-466d-9cce-56f571b9c590" });
        }
    }
}
