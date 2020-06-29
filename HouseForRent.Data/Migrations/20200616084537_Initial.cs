using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseForRent.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApartmentTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "AssetRentStatuses",
                columns: table => new
                {
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetRentStatuses", x => x.Status);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BlockName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractDurations",
                columns: table => new
                {
                    Duration = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDurations", x => x.Duration);
                });

            migrationBuilder.CreateTable(
                name: "ContractStatuses",
                columns: table => new
                {
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractStatuses", x => x.Status);
                });

            migrationBuilder.CreateTable(
                name: "ContractTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "MotorTypes",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorTypes", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "PowerPrice",
                columns: table => new
                {
                    PricePerKw = table.Column<double>(nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerPrice", x => x.PricePerKw);
                });

            migrationBuilder.CreateTable(
                name: "RepairRequestStatuses",
                columns: table => new
                {
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairRequestStatuses", x => x.Status);
                });

            migrationBuilder.CreateTable(
                name: "SewagePrice",
                columns: table => new
                {
                    PricePerM3 = table.Column<double>(nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SewagePrice", x => x.PricePerM3);
                });

            migrationBuilder.CreateTable(
                name: "SupplyPrice",
                columns: table => new
                {
                    PricePerM3 = table.Column<double>(nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplyPrice", x => x.PricePerM3);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitName = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitName);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Code = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    ApartmentTypeType = table.Column<string>(nullable: false),
                    BlockId = table.Column<Guid>(nullable: false),
                    Floor = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Area = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Deposite = table.Column<double>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Note = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_ApartmentTypes_ApartmentTypeType",
                        column: x => x.ApartmentTypeType,
                        principalTable: "ApartmentTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apartments_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CustomerTypeType = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    IdentityCardNumber = table.Column<string>(maxLength: 20, nullable: false),
                    IdentityCardDateIssue = table.Column<DateTime>(nullable: false),
                    IdentityCardPlaceIssue = table.Column<string>(maxLength: 100, nullable: true),
                    Adress = table.Column<string>(maxLength: 100, nullable: true),
                    CardNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Bank = table.Column<string>(maxLength: 100, nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    Note = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerTypes_CustomerTypeType",
                        column: x => x.CustomerTypeType,
                        principalTable: "CustomerTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    AssetTypeType = table.Column<string>(nullable: false),
                    UnitName = table.Column<string>(nullable: false),
                    VAT = table.Column<double>(nullable: false, defaultValue: 10.0),
                    Instock = table.Column<int>(nullable: false, defaultValue: 0),
                    Note = table.Column<string>(maxLength: 500, nullable: true),
                    BlockId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_AssetTypes_AssetTypeType",
                        column: x => x.AssetTypeType,
                        principalTable: "AssetTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assets_Units_UnitName",
                        column: x => x.UnitName,
                        principalTable: "Units",
                        principalColumn: "UnitName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PowerIndexManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false),
                    StartIndex = table.Column<double>(nullable: false),
                    EndIndex = table.Column<double>(nullable: false),
                    PowerPrice = table.Column<double>(nullable: false),
                    Period = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerIndexManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerIndexManagements_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepairRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Status1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairRequests_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairRequests_RepairRequestStatuses_Status1",
                        column: x => x.Status1,
                        principalTable: "RepairRequestStatuses",
                        principalColumn: "Status",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterIndexManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false),
                    StartIndex = table.Column<double>(nullable: false),
                    EndIndex = table.Column<double>(nullable: false),
                    SupplyPrice = table.Column<double>(nullable: false),
                    SewagePrice = table.Column<double>(nullable: false),
                    Period = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterIndexManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterIndexManagements_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false),
                    ContractTypeType = table.Column<string>(nullable: false),
                    Duration1 = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Deposit = table.Column<double>(nullable: false, defaultValue: 0.0),
                    RentAssets = table.Column<string>(maxLength: 200, nullable: true),
                    RentServices = table.Column<string>(nullable: true),
                    Status1 = table.Column<string>(nullable: false),
                    Note = table.Column<string>(maxLength: 500, nullable: true),
                    Description = table.Column<string>(nullable: true, defaultValue: "500")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractTypes_ContractTypeType",
                        column: x => x.ContractTypeType,
                        principalTable: "ContractTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractDurations_Duration1",
                        column: x => x.Duration1,
                        principalTable: "ContractDurations",
                        principalColumn: "Duration",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_ContractStatuses_Status1",
                        column: x => x.Status1,
                        principalTable: "ContractStatuses",
                        principalColumn: "Status",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers_Apartments",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers_Apartments", x => new { x.CustomerId, x.ApartmentId });
                    table.ForeignKey(
                        name: "FK_Customers_Apartments_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Apartments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motorbikes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    MotorTypeType = table.Column<string>(nullable: false),
                    MotorNumber = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorbikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorbikes_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorbikes_MotorTypes_MotorTypeType",
                        column: x => x.MotorTypeType,
                        principalTable: "MotorTypes",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCheckIn = table.Column<DateTime>(nullable: false),
                    DateCheckOut = table.Column<DateTime>(nullable: false),
                    Note = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    ApartmentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitorManagements_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VisitorManagements_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssetRents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    AssetId = table.Column<Guid>(nullable: false),
                    DateRecevice = table.Column<DateTime>(nullable: false),
                    DatePayback = table.Column<DateTime>(nullable: false),
                    Count = table.Column<int>(nullable: false, defaultValue: 1),
                    Price = table.Column<double>(nullable: false),
                    AssetRentStatusStatus = table.Column<string>(nullable: false),
                    Note = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetRents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetRents_Assets_AssetId",
                        column: x => x.AssetId,
                        principalTable: "Assets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetRents_AssetRentStatuses_AssetRentStatusStatus",
                        column: x => x.AssetRentStatusStatus,
                        principalTable: "AssetRentStatuses",
                        principalColumn: "Status",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssetRents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_ApartmentTypeType",
                table: "Apartments",
                column: "ApartmentTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_BlockId",
                table: "Apartments",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRents_AssetId",
                table: "AssetRents",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRents_AssetRentStatusStatus",
                table: "AssetRents",
                column: "AssetRentStatusStatus");

            migrationBuilder.CreateIndex(
                name: "IX_AssetRents_CustomerId",
                table: "AssetRents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_AssetTypeType",
                table: "Assets",
                column: "AssetTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_BlockId",
                table: "Assets",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_UnitName",
                table: "Assets",
                column: "UnitName");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ApartmentId",
                table: "Contracts",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeType",
                table: "Contracts",
                column: "ContractTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Duration1",
                table: "Contracts",
                column: "Duration1");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_Status1",
                table: "Contracts",
                column: "Status1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerTypeType",
                table: "Customers",
                column: "CustomerTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Apartments_ApartmentId",
                table: "Customers_Apartments",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_CustomerId",
                table: "Motorbikes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_MotorTypeType",
                table: "Motorbikes",
                column: "MotorTypeType");

            migrationBuilder.CreateIndex(
                name: "IX_PowerIndexManagements_ApartmentId",
                table: "PowerIndexManagements",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairRequests_ApartmentId",
                table: "RepairRequests",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RepairRequests_Status1",
                table: "RepairRequests",
                column: "Status1");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorManagements_ApartmentId",
                table: "VisitorManagements",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorManagements_CustomerId",
                table: "VisitorManagements",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterIndexManagements_ApartmentId",
                table: "WaterIndexManagements",
                column: "ApartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetRents");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Customers_Apartments");

            migrationBuilder.DropTable(
                name: "Motorbikes");

            migrationBuilder.DropTable(
                name: "PowerIndexManagements");

            migrationBuilder.DropTable(
                name: "PowerPrice");

            migrationBuilder.DropTable(
                name: "RepairRequests");

            migrationBuilder.DropTable(
                name: "SewagePrice");

            migrationBuilder.DropTable(
                name: "SupplyPrice");

            migrationBuilder.DropTable(
                name: "VisitorManagements");

            migrationBuilder.DropTable(
                name: "WaterIndexManagements");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "AssetRentStatuses");

            migrationBuilder.DropTable(
                name: "ContractTypes");

            migrationBuilder.DropTable(
                name: "ContractDurations");

            migrationBuilder.DropTable(
                name: "ContractStatuses");

            migrationBuilder.DropTable(
                name: "MotorTypes");

            migrationBuilder.DropTable(
                name: "RepairRequestStatuses");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "AssetTypes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "CustomerTypes");

            migrationBuilder.DropTable(
                name: "ApartmentTypes");

            migrationBuilder.DropTable(
                name: "Blocks");
        }
    }
}
