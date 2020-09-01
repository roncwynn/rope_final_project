﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Migrations
{
    [DbContext(typeof(ReleaseTasksAPIContext))]
    [Migration("20200901002502_AddedQuestionsSeedData-try3")]
    partial class AddedQuestionsSeedDatatry3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<int>("ReleaseTaskID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReleaseTaskID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Details = "Operations Running Smoothly.",
                            IsVisible = true,
                            ReleaseTaskID = 1
                        },
                        new
                        {
                            ID = 2,
                            Details = "Having some issues.",
                            IsVisible = true,
                            ReleaseTaskID = 1
                        },
                        new
                        {
                            ID = 3,
                            Details = "Runtime errors present",
                            IsVisible = true,
                            ReleaseTaskID = 1
                        },
                        new
                        {
                            ID = 4,
                            Details = "No issues.",
                            IsVisible = true,
                            ReleaseTaskID = 2
                        },
                        new
                        {
                            ID = 5,
                            Details = "Estimated completion in 30 minutes.",
                            IsVisible = true,
                            ReleaseTaskID = 2
                        },
                        new
                        {
                            ID = 6,
                            Details = "Running about 45 minutes behind schedule.",
                            IsVisible = true,
                            ReleaseTaskID = 3
                        },
                        new
                        {
                            ID = 7,
                            Details = "Looking good.",
                            IsVisible = true,
                            ReleaseTaskID = 3
                        },
                        new
                        {
                            ID = 8,
                            Details = "This might be a show stopper.",
                            IsVisible = true,
                            ReleaseTaskID = 4
                        },
                        new
                        {
                            ID = 9,
                            Details = "GO Decision made.",
                            IsVisible = true,
                            ReleaseTaskID = 5
                        },
                        new
                        {
                            ID = 10,
                            Details = "Need help.",
                            IsVisible = true,
                            ReleaseTaskID = 3
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Dakota",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Bernard",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Dan",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Ron",
                            Role = "Developer"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Robert",
                            Role = "Release Manager"
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Priority", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Critical",
                            Value = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "High",
                            Value = 2
                        },
                        new
                        {
                            ID = 3,
                            Name = "Medium",
                            Value = 3
                        },
                        new
                        {
                            ID = 4,
                            Name = "Low",
                            Value = 4
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Question", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseTaskID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ReleaseTaskID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            QuestionText = "Will this be complete on time?"
                        },
                        new
                        {
                            ID = 2,
                            QuestionText = "Are there any issues?"
                        },
                        new
                        {
                            ID = 3,
                            QuestionText = "Are there errors?"
                        },
                        new
                        {
                            ID = 4,
                            QuestionText = "Can this be cancelled?"
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.ReleaseTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AssignedEmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CurrentDueTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentPriorityID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentStatusID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVisisble")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AssignedEmployeeID");

                    b.HasIndex("CurrentPriorityID");

                    b.HasIndex("CurrentStatusID");

                    b.ToTable("ReleaseTasks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 837, DateTimeKind.Local).AddTicks(3799),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 1,
                            CurrentStatusID = 1,
                            Description = "Validate Team Ready for Out of Service Page",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(917),
                            Name = "Validate Readiness"
                        },
                        new
                        {
                            ID = 2,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1724),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 2,
                            Description = "Update Message To Reflect Routine Maintenance",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1755),
                            Name = "Update User Message"
                        },
                        new
                        {
                            ID = 3,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1828),
                            CurrentDueTime = new DateTime(2020, 8, 19, 20, 35, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 3,
                            Description = "Publish Content Updates/Changes, See Content Updates",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1832),
                            Name = "Push Content Changes"
                        },
                        new
                        {
                            ID = 4,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1844),
                            CurrentDueTime = new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 1,
                            Description = "Ensure all modules have correct content changes",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1847),
                            Name = "Verify Content Changes"
                        },
                        new
                        {
                            ID = 5,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1857),
                            CurrentDueTime = new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 1,
                            Description = "Upload all Application Changes to Production",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1860),
                            Name = "Upload App Changes"
                        },
                        new
                        {
                            ID = 6,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1869),
                            CurrentDueTime = new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 1,
                            Description = "Check all Production repositories for current code changes",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1873),
                            Name = "Verify Content Changes"
                        },
                        new
                        {
                            ID = 7,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1883),
                            CurrentDueTime = new DateTime(2020, 8, 19, 21, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 4,
                            Description = "Execute App Container Changes/Updates in Production, See App Container Tasks",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1886),
                            Name = "Execute App Changes"
                        },
                        new
                        {
                            ID = 8,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1895),
                            CurrentDueTime = new DateTime(2020, 8, 19, 22, 45, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 2,
                            Description = "Deploy New U/I Layer Package, See U / I Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1899),
                            Name = "Deploy New UI"
                        },
                        new
                        {
                            ID = 9,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1908),
                            CurrentDueTime = new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 1,
                            Description = "Verify U/I has deployed to Production",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1911),
                            Name = "Verify New UI"
                        },
                        new
                        {
                            ID = 10,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1920),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 3,
                            Description = "Deploy Shared U/I Layer Package  See U / I Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1925),
                            Name = "Deploy Shared UI"
                        },
                        new
                        {
                            ID = 11,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1934),
                            CurrentDueTime = new DateTime(2020, 8, 14, 20, 50, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 1,
                            Description = "Verify Shared U/I has deployed to Production",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1937),
                            Name = "Verify Shared UI"
                        },
                        new
                        {
                            ID = 12,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1947),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 1,
                            Description = "Deploy New Services Layer Package, See Services Layer Code",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1950),
                            Name = "Deploy New Services"
                        },
                        new
                        {
                            ID = 13,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1959),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 1,
                            Description = "Verify Shared U/I has deployed to Production",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1963),
                            Name = "Verify New Services"
                        },
                        new
                        {
                            ID = 14,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1972),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 3,
                            Description = "Perform System Cache Refresh",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1976),
                            Name = "Perform Refresh"
                        },
                        new
                        {
                            ID = 15,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1985),
                            CurrentDueTime = new DateTime(2020, 8, 19, 23, 55, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 3,
                            Description = "Verify System Cache Refresh",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1988),
                            Name = "Verify Refresh"
                        },
                        new
                        {
                            ID = 16,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(1997),
                            CurrentDueTime = new DateTime(2020, 8, 20, 0, 1, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 2,
                            Description = "Bring Down Out of Service Page",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2001),
                            Name = "Remove Service Page"
                        },
                        new
                        {
                            ID = 17,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2010),
                            CurrentDueTime = new DateTime(2020, 8, 21, 1, 15, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 3,
                            Description = "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2013),
                            Name = "Update User Message"
                        },
                        new
                        {
                            ID = 18,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2026),
                            CurrentDueTime = new DateTime(2020, 8, 20, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 1,
                            Description = "Notify Group Validation Can Begin",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2029),
                            Name = "Notify Validation Group"
                        },
                        new
                        {
                            ID = 19,
                            AssignedEmployeeID = 5,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2042),
                            CurrentDueTime = new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 3,
                            Description = "System Monitoring Through Monday",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2046),
                            Name = "Monitor System"
                        },
                        new
                        {
                            ID = 20,
                            AssignedEmployeeID = 5,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2055),
                            CurrentDueTime = new DateTime(2020, 8, 20, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 1,
                            Description = "Enure no steps were missed",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2058),
                            Name = "Complete Final Checklist"
                        },
                        new
                        {
                            ID = 21,
                            AssignedEmployeeID = 5,
                            CreatedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2068),
                            CurrentDueTime = new DateTime(2020, 8, 20, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 1,
                            Description = "Let users know system has been updated.",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 8, 31, 20, 25, 1, 840, DateTimeKind.Local).AddTicks(2071),
                            Name = "Notify Users"
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Status", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "New",
                            Value = 1
                        },
                        new
                        {
                            ID = 2,
                            Name = "In Progress",
                            Value = 2
                        },
                        new
                        {
                            ID = 3,
                            Name = "Done",
                            Value = 3
                        },
                        new
                        {
                            ID = 4,
                            Name = "Cancelled",
                            Value = 4
                        });
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Comment", b =>
                {
                    b.HasOne("RopeFinalProjectBackEnd.Models.ReleaseTask", null)
                        .WithMany("Comments")
                        .HasForeignKey("ReleaseTaskID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.Question", b =>
                {
                    b.HasOne("RopeFinalProjectBackEnd.Models.ReleaseTask", null)
                        .WithMany("Questions")
                        .HasForeignKey("ReleaseTaskID");
                });

            modelBuilder.Entity("RopeFinalProjectBackEnd.Models.ReleaseTask", b =>
                {
                    b.HasOne("RopeFinalProjectBackEnd.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("AssignedEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeFinalProjectBackEnd.Models.Priority", "Priority")
                        .WithMany()
                        .HasForeignKey("CurrentPriorityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RopeFinalProjectBackEnd.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("CurrentStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
