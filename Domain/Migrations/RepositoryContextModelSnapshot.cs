﻿// <auto-generated />
using System;
using Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Fix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Account = "523196861",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 462, DateTimeKind.Local).AddTicks(3535),
                            NickName = "雾曝政枢蘸磅副",
                            Password = "1258548587",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 463, DateTimeKind.Local).AddTicks(4256)
                        },
                        new
                        {
                            Id = 2,
                            Account = "455504138",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(778),
                            NickName = "赢豌谎案",
                            Password = "936210315",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(813)
                        },
                        new
                        {
                            Id = 3,
                            Account = "450630276",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1041),
                            NickName = "霸缆栓迂扰哈",
                            Password = "776343471",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1043)
                        },
                        new
                        {
                            Id = 4,
                            Account = "1566124266",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1214),
                            NickName = "蓄侍婆诡瓷",
                            Password = "1895261234",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1215)
                        },
                        new
                        {
                            Id = 5,
                            Account = "386221349",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1365),
                            NickName = "淑袖故尘档球佐",
                            Password = "1217328392",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1366)
                        },
                        new
                        {
                            Id = 6,
                            Account = "1287529653",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1593),
                            NickName = "揉背尼茹掇裸",
                            Password = "66281381",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1594)
                        },
                        new
                        {
                            Id = 7,
                            Account = "1173567503",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1764),
                            NickName = "嫂坞臃踩怔描",
                            Password = "2097303359",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1765)
                        },
                        new
                        {
                            Id = 8,
                            Account = "564027261",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1966),
                            NickName = "炕榨柿羚悠",
                            Password = "1955453838",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(1967)
                        },
                        new
                        {
                            Id = 9,
                            Account = "228721031",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2115),
                            NickName = "矣伏钱平",
                            Password = "150803890",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2116)
                        },
                        new
                        {
                            Id = 10,
                            Account = "922075987",
                            CreateBy = "System",
                            CreateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2245),
                            NickName = "很瑶泼龋狰",
                            Password = "19990018",
                            UpdateBy = "System",
                            UpdateTime = new DateTime(2020, 1, 4, 13, 4, 59, 466, DateTimeKind.Local).AddTicks(2246)
                        });
                });

            modelBuilder.Entity("Domain.Models.Company", b =>
                {
                    b.OwnsOne("Domain.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("CompanyId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("DetailAddress")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Province")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Region")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}