﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestCore.Data.Context;

namespace TestCore.Data.Migrations
{
    [DbContext(typeof(WorkFlowContext))]
    [Migration("20190325232706_InitConfig")]
    partial class InitConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestCore.Entities.Employees", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256);

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TestCore.Entities.Tasks", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(256);

                    b.Property<string>("EmployeeId")
                        .HasMaxLength(256);

                    b.Property<DateTime>("TaskDateRescived");

                    b.Property<string>("TaskDescription")
                        .HasMaxLength(500);

                    b.Property<bool?>("TaskFinshed");

                    b.Property<string>("TaskTitle")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TestCore.Entities.Tasks", b =>
                {
                    b.HasOne("TestCore.Entities.Employees", "Employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
