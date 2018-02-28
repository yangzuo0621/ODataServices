﻿// <auto-generated />
using CsvToolDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CsvToolDb.Migrations
{
    [DbContext(typeof(CsvToolContext))]
    [Migration("20180228053024_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CsvToolDb.Models.Approval", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Requestor");

                    b.Property<string>("Status");

                    b.Property<DateTime>("SubmittedDate");

                    b.Property<DateTime>("TaskSLADate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Approvals");
                });

            modelBuilder.Entity("CsvToolDb.Models.Request", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("ReportBack");

                    b.Property<string>("Status");

                    b.Property<DateTime?>("SubmittedDate");

                    b.Property<DateTime?>("TaskSLADate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}