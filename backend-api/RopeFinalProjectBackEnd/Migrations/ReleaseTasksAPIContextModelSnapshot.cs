﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Migrations
{
    [DbContext(typeof(ReleaseTasksAPIContext))]
    partial class ReleaseTasksAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("ReleaseTasks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AssignedEmployeeID = 1,
                            CreatedDate = new DateTime(2020, 7, 28, 12, 36, 32, 235, DateTimeKind.Local).AddTicks(2077),
                            CurrentDueTime = new DateTime(2020, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 1,
                            CurrentStatusID = 1,
                            Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 7, 28, 12, 36, 32, 237, DateTimeKind.Local).AddTicks(9956),
                            Name = "Release Task 1"
                        },
                        new
                        {
                            ID = 2,
                            AssignedEmployeeID = 2,
                            CreatedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(725),
                            CurrentDueTime = new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 2,
                            CurrentStatusID = 2,
                            Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(755),
                            Name = "Release Task 2"
                        },
                        new
                        {
                            ID = 3,
                            AssignedEmployeeID = 3,
                            CreatedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(785),
                            CurrentDueTime = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 3,
                            CurrentStatusID = 3,
                            Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(794),
                            Name = "Release Task 3"
                        },
                        new
                        {
                            ID = 4,
                            AssignedEmployeeID = 4,
                            CreatedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(807),
                            CurrentDueTime = new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CurrentPriorityID = 4,
                            CurrentStatusID = 4,
                            Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.",
                            IsVisisble = true,
                            LastModifiedDate = new DateTime(2020, 7, 28, 12, 36, 32, 238, DateTimeKind.Local).AddTicks(811),
                            Name = "Release Task 4"
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
#pragma warning restore 612, 618
        }
    }
}
