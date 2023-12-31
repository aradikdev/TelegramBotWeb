﻿// <auto-generated />
using System;
using DevSpaceWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevSpaceWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230527070830_Init7")]
    partial class Init7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DevSpaceWeb.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOur")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MessageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChatId = 1,
                            IsOur = true,
                            MessageDate = new DateTime(2023, 5, 27, 13, 8, 30, 511, DateTimeKind.Local).AddTicks(1793),
                            MessageText = "Hi",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ChatId = 1,
                            IsOur = false,
                            MessageDate = new DateTime(2023, 5, 27, 13, 9, 30, 511, DateTimeKind.Local).AddTicks(1803),
                            MessageText = "Hello",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            ChatId = 1,
                            IsOur = true,
                            MessageDate = new DateTime(2023, 5, 27, 13, 10, 30, 511, DateTimeKind.Local).AddTicks(1808),
                            MessageText = "How are you?",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            ChatId = 1,
                            IsOur = false,
                            MessageDate = new DateTime(2023, 5, 27, 13, 11, 30, 511, DateTimeKind.Local).AddTicks(1810),
                            MessageText = "I'm good, thanks!",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            ChatId = 1,
                            IsOur = true,
                            MessageDate = new DateTime(2023, 5, 27, 13, 12, 30, 511, DateTimeKind.Local).AddTicks(1811),
                            MessageText = "What have you been up to?",
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            ChatId = 1,
                            IsOur = false,
                            MessageDate = new DateTime(2023, 5, 27, 13, 13, 30, 511, DateTimeKind.Local).AddTicks(1812),
                            MessageText = "Not much, just working on a project",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DevSpaceWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChatId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastMessage")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChatId = 1,
                            IsActive = true,
                            Name = "Я"
                        },
                        new
                        {
                            Id = 2,
                            ChatId = 1,
                            IsActive = true,
                            Name = "Alice"
                        });
                });

            modelBuilder.Entity("DevSpaceWeb.Models.Message", b =>
                {
                    b.HasOne("DevSpaceWeb.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DevSpaceWeb.Models.User", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
