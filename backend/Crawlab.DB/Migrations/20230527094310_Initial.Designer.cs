﻿// <auto-generated />
using System;
using Crawlab.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Crawlab.DB.Migrations
{
    [DbContext(typeof(CrawlabDbContext))]
    [Migration("20230527094310_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Crawlab.Model.Models.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MaxRunners")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Status");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cron")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SpiderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("SpiderId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Spider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("SpiderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("SpiderId");

                    b.ToTable("Spiders");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("EndedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("NodeId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int?>("SpiderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("NodeId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SpiderId");

                    b.HasIndex("Status");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Crawlab.Model.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Crawlab.Model.Relations.SpiderNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NodeId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("NodeId1")
                        .HasColumnType("int");

                    b.Property<string>("SpiderId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("SpiderId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("NodeId1");

                    b.HasIndex("SpiderId1");

                    b.ToTable("SpiderNodes");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Schedule", b =>
                {
                    b.HasOne("Crawlab.Model.Models.Spider", "Spider")
                        .WithMany()
                        .HasForeignKey("SpiderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Spider");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Spider", b =>
                {
                    b.HasOne("Crawlab.Model.Models.Spider", null)
                        .WithMany("Spiders")
                        .HasForeignKey("SpiderId");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Task", b =>
                {
                    b.HasOne("Crawlab.Model.Models.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId");

                    b.HasOne("Crawlab.Model.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.HasOne("Crawlab.Model.Models.Spider", "Spider")
                        .WithMany()
                        .HasForeignKey("SpiderId");

                    b.Navigation("Node");

                    b.Navigation("Schedule");

                    b.Navigation("Spider");
                });

            modelBuilder.Entity("Crawlab.Model.Relations.SpiderNode", b =>
                {
                    b.HasOne("Crawlab.Model.Models.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId1");

                    b.HasOne("Crawlab.Model.Models.Spider", "Spider")
                        .WithMany("SpiderNodes")
                        .HasForeignKey("SpiderId1");

                    b.Navigation("Node");

                    b.Navigation("Spider");
                });

            modelBuilder.Entity("Crawlab.Model.Models.Spider", b =>
                {
                    b.Navigation("SpiderNodes");

                    b.Navigation("Spiders");
                });
#pragma warning restore 612, 618
        }
    }
}
