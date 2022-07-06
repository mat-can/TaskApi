﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskApi.Utils;

#nullable disable

namespace TaskApi.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20220706132621_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskApi.Models.Category", b =>
                {
                    b.Property<Guid>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("IdCategory");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            IdCategory = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                            Name = "WorkStuff",
                            Weight = 20
                        },
                        new
                        {
                            IdCategory = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                            Name = "PersonalStuff",
                            Weight = 50
                        });
                });

            modelBuilder.Entity("TaskApi.Models.Tasks", b =>
                {
                    b.Property<Guid>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("IdCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TaskPriorities")
                        .HasColumnType("int");

                    b.Property<int>("TaskState")
                        .HasColumnType("int");

                    b.Property<int>("TaskTime")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("IdTask");

                    b.HasIndex("IdCategory");

                    b.ToTable("Tasks", (string)null);

                    b.HasData(
                        new
                        {
                            IdTask = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb410"),
                            CreateTime = new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2660),
                            IdCategory = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb4ef"),
                            TaskPriorities = 1,
                            TaskState = 2,
                            TaskTime = 0,
                            Title = "Answer LinkedIn messages"
                        },
                        new
                        {
                            IdTask = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb411"),
                            CreateTime = new DateTime(2022, 7, 6, 15, 26, 21, 498, DateTimeKind.Local).AddTicks(2735),
                            IdCategory = new Guid("fe2de405-c38e-4c90-ac52-da0540dfb402"),
                            TaskPriorities = 1,
                            TaskState = 2,
                            TaskTime = 0,
                            Title = "Cook lunch"
                        });
                });

            modelBuilder.Entity("TaskApi.Models.Tasks", b =>
                {
                    b.HasOne("TaskApi.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TaskApi.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
