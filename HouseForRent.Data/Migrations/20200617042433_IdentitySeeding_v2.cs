using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseForRent.Data.Migrations
{
    public partial class IdentitySeeding_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AppUsers");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AppRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ApartmentTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("9e4fbeb0-4a01-4a71-ad36-ce0844805123"), "Base", "Base" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("9bf83243-05e6-4f30-a591-ab1e35e0bd91"),
                column: "ConcurrencyStamp",
                value: "fec168e7-d45a-443e-9101-d374b9cd33a6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec2d3359-98c7-4ce8-a1bf-33345e7e3424"),
                column: "ConcurrencyStamp",
                value: "0b790c84-73fd-4fc9-9e20-136cce1f9ccd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("023d8b3f-a56b-4a12-92e1-b066210cd854"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1391771e-53df-4ec6-93f1-685da06af5f1", "AQAAAAEAACcQAAAAECUfjcd98d0EM28tW872NANQ7I3U+ogbnLboeMRFE8x8Zl3ac0lzq18NGQq86x6CFw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("2a222ed2-fc1d-4cd2-96e1-cca3f08db5f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a3cb912-c559-4244-87f4-c9785cf93707", "AQAAAAEAACcQAAAAEHL/2/gL86cq75R1/nCyVD+sKjH9jsCxXBY3EiSAejWxcM9ob1AtHfXd2ySBTOJvWA==" });

            migrationBuilder.InsertData(
                table: "AssetRentStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("d41c0206-b166-43d2-958e-5a6b4a784ff6"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "AssetTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("8f8dcb75-405f-47ad-b112-1a02072e923b"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Blocks",
                columns: new[] { "Id", "BlockName", "Description" },
                values: new object[] { new Guid("fcffbbc7-5201-466a-a4d4-1c9ab81ec059"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractDurations",
                columns: new[] { "Id", "Description", "Duration" },
                values: new object[,]
                {
                    { new Guid("3a34a945-4566-4ca3-b7ff-01267c33b5f3"), "3 tháng", "3 tháng" },
                    { new Guid("210a2d77-c03c-45be-b2d4-78756aea99d6"), "6 tháng", "6 tháng" },
                    { new Guid("36a2910a-95f4-4c8f-bacc-b46f97c93cd0"), "1 năm", "1 năm" }
                });

            migrationBuilder.InsertData(
                table: "ContractStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("cd181dae-936a-4992-a67a-46a72e40dbab"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "ContractTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("fc6299ad-a398-420d-ba51-f8fcafce43da"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "CustomerTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("ae96808f-d98b-45d1-a60b-a7ad5a493fac"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "MotorTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("9ff3fd6d-7aee-45b2-b495-915df9de6f49"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "RepairRequestStatuses",
                columns: new[] { "Id", "Description", "Status" },
                values: new object[] { new Guid("4e8f27c5-3835-4803-a43a-910244d42570"), "Base", "Base" });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "UnitName" },
                values: new object[] { new Guid("71e0ef66-8240-4d92-a711-6af1730f358b"), "Base", "Base" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRoles",
                table: "AppRoles");

            migrationBuilder.DeleteData(
                table: "ApartmentTypes",
                keyColumn: "Id",
                keyValue: new Guid("9e4fbeb0-4a01-4a71-ad36-ce0844805123"));

            migrationBuilder.DeleteData(
                table: "AssetRentStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d41c0206-b166-43d2-958e-5a6b4a784ff6"));

            migrationBuilder.DeleteData(
                table: "AssetTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f8dcb75-405f-47ad-b112-1a02072e923b"));

            migrationBuilder.DeleteData(
                table: "Blocks",
                keyColumn: "Id",
                keyValue: new Guid("fcffbbc7-5201-466a-a4d4-1c9ab81ec059"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("210a2d77-c03c-45be-b2d4-78756aea99d6"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("36a2910a-95f4-4c8f-bacc-b46f97c93cd0"));

            migrationBuilder.DeleteData(
                table: "ContractDurations",
                keyColumn: "Id",
                keyValue: new Guid("3a34a945-4566-4ca3-b7ff-01267c33b5f3"));

            migrationBuilder.DeleteData(
                table: "ContractStatuses",
                keyColumn: "Id",
                keyValue: new Guid("cd181dae-936a-4992-a67a-46a72e40dbab"));

            migrationBuilder.DeleteData(
                table: "ContractTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc6299ad-a398-420d-ba51-f8fcafce43da"));

            migrationBuilder.DeleteData(
                table: "CustomerTypes",
                keyColumn: "Id",
                keyValue: new Guid("ae96808f-d98b-45d1-a60b-a7ad5a493fac"));

            migrationBuilder.DeleteData(
                table: "MotorTypes",
                keyColumn: "Id",
                keyValue: new Guid("9ff3fd6d-7aee-45b2-b495-915df9de6f49"));

            migrationBuilder.DeleteData(
                table: "RepairRequestStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4e8f27c5-3835-4803-a43a-910244d42570"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("71e0ef66-8240-4d92-a711-6af1730f358b"));

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AppRoles",
                newName: "Roles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.InsertData(
                table: "ApartmentTypes",
                columns: new[] { "Id", "Description", "Type" },
                values: new object[] { new Guid("85724b2c-04f7-48a3-9bbb-6b776225b797"), "Base", "Base" });

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
                    { new Guid("283c7556-2527-447f-adcd-3c885e4c05d8"), "6 tháng", "6 tháng" },
                    { new Guid("4a33e824-6e7a-4c19-8018-b42525d96951"), "1 năm", "1 năm" }
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

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9bf83243-05e6-4f30-a591-ab1e35e0bd91"),
                column: "ConcurrencyStamp",
                value: "c21e65d4-cf1f-4cf0-a435-9d553b14012c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ec2d3359-98c7-4ce8-a1bf-33345e7e3424"),
                column: "ConcurrencyStamp",
                value: "c339e85c-c06e-42c5-ac64-d369e0a790a5");

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Description", "UnitName" },
                values: new object[] { new Guid("bdeda95c-4b14-44c4-a79c-d1f47ef1d755"), "Base", "Base" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("023d8b3f-a56b-4a12-92e1-b066210cd854"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44525910-dcde-4b19-9cec-e83c1a7dd0b9", "AQAAAAEAACcQAAAAEDOcJ9b3ScLPtrv3flG24IKdCO+lFGaGK7gf5TtPkEif4ccobyfr/tSz4y9iuD0dgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2a222ed2-fc1d-4cd2-96e1-cca3f08db5f6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "28edeefe-22e4-43ca-a997-1f59750f5b36", "AQAAAAEAACcQAAAAEMU+xTAYOF7/m64OgKkXZQee79o1sCMfSYrl0fnhqnO+1HM9xlt1AgeX4IgvaQegVg==" });
        }
    }
}
