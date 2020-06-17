﻿// <auto-generated />
using System;
using HouseForRent.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseForRent.Data.Migrations
{
    [DbContext(typeof(HouseForRentDbContext))]
    [Migration("20200616095845_Initial_v2")]
    partial class Initial_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseForRent.Data.Entities.Apartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<Guid>("BlockId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<double>("Deposite")
                        .HasColumnType("float");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentTypeId");

                    b.HasIndex("BlockId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.ApartmentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ApartmentTypes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlockId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Instock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<Guid>("UnitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("VAT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(10.0);

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("BlockId");

                    b.HasIndex("UnitId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.AssetRent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssetRentStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatePayback")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRecevice")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("AssetRentStatusId");

                    b.HasIndex("CustomerId");

                    b.ToTable("AssetRents");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.AssetRentStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AssetRentStatuses");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.AssetType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Block", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BlockName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Contract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContractTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Deposit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("500");

                    b.Property<Guid>("DurationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("RentAssets")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("RentServices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("ContractTypeId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DurationId");

                    b.HasIndex("StatusId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.ContractDuration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ContractDurations");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.ContractStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ContractStatuses");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.ContractType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ContractTypes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Bank")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<Guid>("CustomerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime>("IdentityCardDateIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("IdentityCardPlaceIssue")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.CustomerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CustomerTypes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Customer_Apartment", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CustomerId", "ApartmentId");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Customers_Apartments");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.MotorType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("MotorTypes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Motorbike", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MotorNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("MotorTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MotorTypeId");

                    b.ToTable("Motorbikes");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.PowerIndexManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EndIndex")
                        .HasColumnType("float");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<double>("PowerPrice")
                        .HasColumnType("float");

                    b.Property<double>("StartIndex")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("PowerIndexManagements");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.PowerPrice", b =>
                {
                    b.Property<double>("PricePerKw")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.HasKey("PricePerKw");

                    b.ToTable("PowerPrice");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.RepairRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("StatusId");

                    b.ToTable("RepairRequests");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.RepairRequestStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("RepairRequestStatuses");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.SewagePrice", b =>
                {
                    b.Property<double>("PricePerM3")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.HasKey("PricePerM3");

                    b.ToTable("SewagePrice");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.SupplyPrice", b =>
                {
                    b.Property<double>("PricePerM3")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.HasKey("PricePerM3");

                    b.ToTable("SupplyPrice");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("UnitName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.VisitorManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("CustomerId");

                    b.ToTable("VisitorManagements");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.WaterIndexManagement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EndIndex")
                        .HasColumnType("float");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<double>("SewagePrice")
                        .HasColumnType("float");

                    b.Property<double>("StartIndex")
                        .HasColumnType("float");

                    b.Property<double>("SupplyPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("WaterIndexManagements");
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Apartment", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.ApartmentType", "ApartmentType")
                        .WithMany("Apartments")
                        .HasForeignKey("ApartmentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Block", "Block")
                        .WithMany("Apartments")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Asset", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Block", "Block")
                        .WithMany("Assets")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Unit", "Unit")
                        .WithMany("Assets")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.AssetRent", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Asset", "Asset")
                        .WithMany("AssetRents")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.AssetRentStatus", "AssetRentStatus")
                        .WithMany("AssetRents")
                        .HasForeignKey("AssetRentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Customer", "Customer")
                        .WithMany("AssetRents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Contract", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("Contracts")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.ContractType", "ContractType")
                        .WithMany("Contracts")
                        .HasForeignKey("ContractTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Customer", "Customer")
                        .WithMany("Contracts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.ContractDuration", "Duration")
                        .WithMany("Contracts")
                        .HasForeignKey("DurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.ContractStatus", "Status")
                        .WithMany("Contracts")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Customer", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.CustomerType", "CustomerType")
                        .WithMany("Customers")
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Customer_Apartment", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("Customers_Apartments")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Customer", "Customer")
                        .WithMany("Customers_Apartments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.Motorbike", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Customer", "Customer")
                        .WithMany("Motorbikes")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.MotorType", "MotorType")
                        .WithMany("Motorbikes")
                        .HasForeignKey("MotorTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.PowerIndexManagement", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("PowerIndexManagements")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.RepairRequest", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("RepairRequests")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.RepairRequestStatus", "Status")
                        .WithMany("RepairRequests")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.VisitorManagement", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("VisitorManagements")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HouseForRent.Data.Entities.Customer", "Customer")
                        .WithMany("VisitorManagements")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HouseForRent.Data.Entities.WaterIndexManagement", b =>
                {
                    b.HasOne("HouseForRent.Data.Entities.Apartment", "Apartment")
                        .WithMany("WaterIndexManagements")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
