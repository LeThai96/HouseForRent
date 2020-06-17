using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseForRent.Data.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 100,
                nullable: true);

            migrationBuilder.InsertData(
                table: "ApartmentTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("58c67da3-ba11-40b6-ac3c-58f71de9a87e"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "AssetRentStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("725614f4-ec24-4092-b2a0-136e9e59b137"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("ea4edb43-4f30-409f-b330-ddbf209cb1d0"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "BlockName", "Description" },
                values: new object[] { new Guid("e670cf11-8fd1-411a-9493-89d53b3e7325"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractDurations",
                columns: new[] { "Id", "Description", "Duration" },
                values: new object[,]
                {
                    { new Guid("360a2eb0-3c5e-4755-bc5c-b1ea587bb25e"), "3 tháng", "3 tháng" },
                    { new Guid("50ca500a-489d-498e-acf8-8bf5d3ec6c26"), "6 tháng", "6 tháng" },
                    { new Guid("13d9d685-0096-45c0-ae4c-7c4375ab26fa"), "1 năm", "1 năm" }
                });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("1c98e0f9-8756-48b6-87ca-c0ffdd98420c"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("08079b67-41ad-455a-bb1b-96e4a48dab18"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("d053f548-d586-4173-8e4e-65417a72c92d"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "MotorTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("0d8d8948-aa50-47c0-8620-c9954b2a1b04"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "RepairRequestStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("44e14259-2583-430c-ba00-8e4bfe05c047"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "UnitName" },
                values: new object[] { new Guid("5ea3f85f-fe1c-4586-b7b8-de21f909e67d"), "Base", "Base" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("58c67da3-ba11-40b6-ac3c-58f71de9a87e"));

            migrationBuilder.DeleteData(
                table: "AssetRentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("725614f4-ec24-4092-b2a0-136e9e59b137"));

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: new Guid("ea4edb43-4f30-409f-b330-ddbf209cb1d0"));

            migrationBuilder.DeleteData(
                table: "Blocks",
                keyColumn: "Id",
                keyValue: new Guid("e670cf11-8fd1-411a-9493-89d53b3e7325"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("13d9d685-0096-45c0-ae4c-7c4375ab26fa"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("360a2eb0-3c5e-4755-bc5c-b1ea587bb25e"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("50ca500a-489d-498e-acf8-8bf5d3ec6c26"));

            migrationBuilder.DeleteData(
                table: "ContractStatuses",
                keyColumn: "Id",
                keyValue: new Guid("1c98e0f9-8756-48b6-87ca-c0ffdd98420c"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("08079b67-41ad-455a-bb1b-96e4a48dab18"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("d053f548-d586-4173-8e4e-65417a72c92d"));

            migrationBuilder.DeleteData(
                table: "MotorTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d8d8948-aa50-47c0-8620-c9954b2a1b04"));

            migrationBuilder.DeleteData(
                table: "RepairRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("44e14259-2583-430c-ba00-8e4bfe05c047"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5ea3f85f-fe1c-4586-b7b8-de21f909e67d"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
