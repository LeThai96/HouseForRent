using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseForRent.Data.Migrations
{
    public partial class Initial_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_ApartmentTypes_ApartmentTypeType",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRents_AssetRentStatuses_AssetRentStatusStatus",
                table: "AssetRents");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeType",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Units_UnitName",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeType",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractDurations_Duration1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractStatuses_Status1",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeType",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_MotorTypes_MotorTypeType",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairRequests_RepairRequestStatuses_Status1",
                table: "RepairRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairRequestStatuses",
                table: "RepairRequestStatuses");

            migrationBuilder.DropIndex(
                name: "IX_RepairRequests_Status1",
                table: "RepairRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotorTypes",
                table: "MotorTypes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_MotorTypeType",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerTypeType",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractTypes",
                table: "ContractTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractStatuses",
                table: "ContractStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractTypeType",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_Duration1",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_Status1",
                table: "Contracts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDurations",
                table: "ContractDurations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetTypeType",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_UnitName",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetRentStatuses",
                table: "AssetRentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AssetRents_AssetRentStatusStatus",
                table: "AssetRents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_ApartmentTypeType",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Status1",
                table: "RepairRequests");

            migrationBuilder.DropColumn(
                name: "MotorTypeType",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "CustomerTypeType",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContractTypeType",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Duration1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Status1",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "AssetTypeType",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "UnitName",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetRentStatusStatus",
                table: "AssetRents");

            migrationBuilder.DropColumn(
                name: "ApartmentTypeType",
                table: "Apartments");

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "Units",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Units",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RepairRequestStatuses",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "RepairRequestStatuses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "RepairRequests",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "MotorTypes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "MotorTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MotorTypeId",
                table: "Motorbikes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CustomerTypes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CustomerTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerTypeId",
                table: "Customers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ContractTypes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ContractTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ContractStatuses",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ContractStatuses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ContractTypeId",
                table: "Contracts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DurationId",
                table: "Contracts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatusId",
                table: "Contracts",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "ContractDurations",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ContractDurations",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "AssetTypes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AssetTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssetTypeId",
                table: "Assets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UnitId",
                table: "Assets",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AssetRentStatuses",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AssetRentStatuses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "AssetRentStatusId",
                table: "AssetRents",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApartmentTypes",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ApartmentTypes",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Apartments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ApartmentTypeId",
                table: "Apartments",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairRequestStatuses",
                table: "RepairRequestStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotorTypes",
                table: "MotorTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractTypes",
                table: "ContractTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractStatuses",
                table: "ContractStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDurations",
                table: "ContractDurations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetRentStatuses",
                table: "AssetRentStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_RepairRequests_StatusId",
                table: "RepairRequests",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_MotorTypeId",
                table: "Motorbikes",
                column: "MotorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_DurationId",
                table: "Contracts",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_StatusId",
                table: "Contracts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UnitId",
                table: "Assets",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRents_AssetRentStatusId",
                table: "AssetRents",
                column: "AssetRentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentTypeId",
                table: "Apartments",
                column: "ApartmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_ApartmentTypes_ApartmentTypeId",
                table: "Apartments",
                column: "ApartmentTypeId",
                principalTable: "ApartmentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRents_AssetRentStatuses_AssetRentStatusId",
                table: "AssetRents",
                column: "AssetRentStatusId",
                principalTable: "AssetRentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets",
                column: "AssetTypeId",
                principalTable: "AssetTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Units_UnitId",
                table: "Assets",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId",
                principalTable: "ContractTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractDurations_DurationId",
                table: "Contracts",
                column: "DurationId",
                principalTable: "ContractDurations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractStatuses_StatusId",
                table: "Contracts",
                column: "StatusId",
                principalTable: "ContractStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_MotorTypes_MotorTypeId",
                table: "Motorbikes",
                column: "MotorTypeId",
                principalTable: "MotorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairRequests_RepairRequestStatuses_StatusId",
                table: "RepairRequests",
                column: "StatusId",
                principalTable: "RepairRequestStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_ApartmentTypes_ApartmentTypeId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetRents_AssetRentStatuses_AssetRentStatusId",
                table: "AssetRents");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Assets_Units_UnitId",
                table: "Assets");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractDurations_DurationId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_ContractStatuses_StatusId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_MotorTypes_MotorTypeId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairRequests_RepairRequestStatuses_StatusId",
                table: "RepairRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairRequestStatuses",
                table: "RepairRequestStatuses");

            migrationBuilder.DropIndex(
                name: "IX_RepairRequests_StatusId",
                table: "RepairRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MotorTypes",
                table: "MotorTypes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_MotorTypeId",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractTypes",
                table: "ContractTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractStatuses",
                table: "ContractStatuses");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_DurationId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_StatusId",
                table: "Contracts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractDurations",
                table: "ContractDurations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes");

            migrationBuilder.DropIndex(
                name: "IX_Assets_AssetTypeId",
                table: "Assets");

            migrationBuilder.DropIndex(
                name: "IX_Assets_UnitId",
                table: "Assets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetRentStatuses",
                table: "AssetRentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_AssetRents_AssetRentStatusId",
                table: "AssetRents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_ApartmentTypeId",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RepairRequestStatuses");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "RepairRequests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MotorTypes");

            migrationBuilder.DropColumn(
                name: "MotorTypeId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CustomerTypes");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContractTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContractStatuses");

            migrationBuilder.DropColumn(
                name: "ContractTypeId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ContractDurations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AssetTypes");

            migrationBuilder.DropColumn(
                name: "AssetTypeId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AssetRentStatuses");

            migrationBuilder.DropColumn(
                name: "AssetRentStatusId",
                table: "AssetRents");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApartmentTypes");

            migrationBuilder.DropColumn(
                name: "ApartmentTypeId",
                table: "Apartments");

            migrationBuilder.AlterColumn<string>(
                name: "UnitName",
                table: "Units",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RepairRequestStatuses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status1",
                table: "RepairRequests",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "MotorTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotorTypeType",
                table: "Motorbikes",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CustomerTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerTypeType",
                table: "Customers",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ContractTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ContractStatuses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContractTypeType",
                table: "Contracts",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Duration1",
                table: "Contracts",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status1",
                table: "Contracts",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "ContractDurations",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "AssetTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetTypeType",
                table: "Assets",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnitName",
                table: "Assets",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "AssetRentStatuses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetRentStatusStatus",
                table: "AssetRents",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "ApartmentTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Apartments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "ApartmentTypeType",
                table: "Apartments",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "UnitName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairRequestStatuses",
                table: "RepairRequestStatuses",
                column: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MotorTypes",
                table: "MotorTypes",
                column: "Type");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerTypes",
                table: "CustomerTypes",
                column: "Type");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractTypes",
                table: "ContractTypes",
                column: "Type");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractStatuses",
                table: "ContractStatuses",
                column: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractDurations",
                table: "ContractDurations",
                column: "Duration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetTypes",
                table: "AssetTypes",
                column: "Type");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetRentStatuses",
                table: "AssetRentStatuses",
                column: "Status");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApartmentTypes",
                table: "ApartmentTypes",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_RepairRequests_Status1",
                table: "RepairRequests",
                column: "Status1");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_MotorTypeType",
                table: "Motorbikes",
                column: "MotorTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypeType",
                table: "Customers",
                column: "CustomerTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeType",
                table: "Contracts",
                column: "ContractTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Duration1",
                table: "Contracts",
                column: "Duration1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Status1",
                table: "Contracts",
                column: "Status1");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeType",
                table: "Assets",
                column: "AssetTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UnitName",
                table: "Assets",
                column: "UnitName");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRents_AssetRentStatusStatus",
                table: "AssetRents",
                column: "AssetRentStatusStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentTypeType",
                table: "Apartments",
                column: "ApartmentTypeType");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_ApartmentTypes_ApartmentTypeType",
                table: "Apartments",
                column: "ApartmentTypeType",
                principalTable: "ApartmentTypes",
                principalColumn: "Type",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetRents_AssetRentStatuses_AssetRentStatusStatus",
                table: "AssetRents",
                column: "AssetRentStatusStatus",
                principalTable: "AssetRentStatuses",
                principalColumn: "Status",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_AssetTypes_AssetTypeType",
                table: "Assets",
                column: "AssetTypeType",
                principalTable: "AssetTypes",
                principalColumn: "Type",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assets_Units_UnitName",
                table: "Assets",
                column: "UnitName",
                principalTable: "Units",
                principalColumn: "UnitName",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractTypes_ContractTypeType",
                table: "Contracts",
                column: "ContractTypeType",
                principalTable: "ContractTypes",
                principalColumn: "Type",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractDurations_Duration1",
                table: "Contracts",
                column: "Duration1",
                principalTable: "ContractDurations",
                principalColumn: "Duration",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_ContractStatuses_Status1",
                table: "Contracts",
                column: "Status1",
                principalTable: "ContractStatuses",
                principalColumn: "Status",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeType",
                table: "Customers",
                column: "CustomerTypeType",
                principalTable: "CustomerTypes",
                principalColumn: "Type",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_MotorTypes_MotorTypeType",
                table: "Motorbikes",
                column: "MotorTypeType",
                principalTable: "MotorTypes",
                principalColumn: "Type",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairRequests_RepairRequestStatuses_Status1",
                table: "RepairRequests",
                column: "Status1",
                principalTable: "RepairRequestStatuses",
                principalColumn: "Status",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
