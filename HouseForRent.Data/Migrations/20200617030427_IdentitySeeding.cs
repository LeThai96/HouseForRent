using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseForRent.Data.Migrations
{
    public partial class IdentitySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AppRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogin",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRole", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserToken", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ApartmentTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("85724b2c-04f7-48a3-9bbb-6b776225b797"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9bf83243-05e6-4f30-a591-ab1e35e0bd91"), new Guid("023d8b3f-a56b-4a12-92e1-b066210cd854") },
                    { new Guid("ec2d3359-98c7-4ce8-a1bf-33345e7e3424"), new Guid("2a222ed2-fc1d-4cd2-96e1-cca3f08db5f6") }
                });

            migrationBuilder.InsertData(
                table: "AssetRentStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("a2f2c6f1-b555-4983-816e-945fa084d36d"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("fe543ae3-f3e4-43df-9e2c-4e4b710a26c7"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "BlockName", "Description" },
                values: new object[] { new Guid("619cc3f1-61d9-4f38-9cd9-5caed43de443"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractDurations",
                columns: new[] { "Id", "Description", "Duration" },
                values: new object[,]
                {
                    { new Guid("28b3c45f-02cb-4582-b133-093e7fc7f75a"), "3 tháng", "3 tháng" },
                    { new Guid("4a33e824-6e7a-4c19-8018-b42525d96951"), "1 năm", "1 năm" },
                    { new Guid("283c7556-2527-447f-adcd-3c885e4c05d8"), "6 tháng", "6 tháng" }
                });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("4f7746cf-a49a-458a-8534-2f4db833a30b"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("e8293329-1179-4aa9-a67f-693f80df7de8"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("5f354ab3-19b2-4e12-9d6e-effbecebcff3"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "MotorTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("2e3a34da-b545-45c2-a9fb-112b445bb4c8"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "RepairRequestStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("27524900-e767-4d27-a2a8-db6908b8550c"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9bf83243-05e6-4f30-a591-ab1e35e0bd91"), "c21e65d4-cf1f-4cf0-a435-9d553b14012c", null, "admin", "admin" },
                    { new Guid("ec2d3359-98c7-4ce8-a1bf-33345e7e3424"), "c339e85c-c06e-42c5-ac64-d369e0a790a5", null, "manager", "manager" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "UnitName" },
                values: new object[] { new Guid("bdeda95c-4b14-44c4-a79c-d1f47ef1d755"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("023d8b3f-a56b-4a12-92e1-b066210cd854"), 0, "44525910-dcde-4b19-9cec-e83c1a7dd0b9", "le.dinhthai00@gmail.com", true, false, null, null, "le.dinhthai00@gmail.com", "admin", "AQAAAAEAACcQAAAAEDOcJ9b3ScLPtrv3flG24IKdCO+lFGaGK7gf5TtPkEif4ccobyfr/tSz4y9iuD0dgQ==", null, false, "", false, "admin" },
                    { new Guid("2a222ed2-fc1d-4cd2-96e1-cca3f08db5f6"), 0, "28edeefe-22e4-43ca-a997-1f59750f5b36", "le.dinhthai00@gmail.com", true, false, null, null, "le.dinhthai00@gmail.com", "manager", "AQAAAAEAACcQAAAAEMU+xTAYOF7/m64OgKkXZQee79o1sCMfSYrl0fnhqnO+1HM9xlt1AgeX4IgvaQegVg==", null, false, "", false, "manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaim");

            migrationBuilder.DropTable(
                name: "AppUserClaim");

            migrationBuilder.DropTable(
                name: "AppUserLogin");

            migrationBuilder.DropTable(
                name: "AppUserRole");

            migrationBuilder.DropTable(
                name: "AppUserToken");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "ApartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("85724b2c-04f7-48a3-9bbb-6b776225b797"));

            migrationBuilder.DeleteData(
                table: "AssetRentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a2f2c6f1-b555-4983-816e-945fa084d36d"));

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: new Guid("fe543ae3-f3e4-43df-9e2c-4e4b710a26c7"));

            migrationBuilder.DeleteData(
                table: "Blocks",
                keyColumn: "Id",
                keyValue: new Guid("619cc3f1-61d9-4f38-9cd9-5caed43de443"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("283c7556-2527-447f-adcd-3c885e4c05d8"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("28b3c45f-02cb-4582-b133-093e7fc7f75a"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("4a33e824-6e7a-4c19-8018-b42525d96951"));

            migrationBuilder.DeleteData(
                table: "ContractStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4f7746cf-a49a-458a-8534-2f4db833a30b"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8293329-1179-4aa9-a67f-693f80df7de8"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("5f354ab3-19b2-4e12-9d6e-effbecebcff3"));

            migrationBuilder.DeleteData(
                table: "MotorTypes",
                keyColumn: "Id",
                keyValue: new Guid("2e3a34da-b545-45c2-a9fb-112b445bb4c8"));

            migrationBuilder.DeleteData(
                table: "RepairRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("27524900-e767-4d27-a2a8-db6908b8550c"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("bdeda95c-4b14-44c4-a79c-d1f47ef1d755"));

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
    }
}
