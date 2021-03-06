﻿// <auto-generated />
using System;
using CfWorkshopDotNetCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CfWorkshopDotNetCore.Migrations
{
    [DbContext(typeof(CfWorkshopContext))]
    [Migration("20180911212501_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CfWorkshopDotNetCore.Models.Note", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Note");

                    b.HasData(
                        new { ID = 1, Created = new DateTime(2018, 9, 11, 16, 25, 1, 128, DateTimeKind.Local), Text = "Note #1" },
                        new { ID = 2, Created = new DateTime(2018, 9, 11, 16, 25, 1, 161, DateTimeKind.Local), Text = "Note #2" },
                        new { ID = 3, Created = new DateTime(2018, 9, 11, 16, 25, 1, 161, DateTimeKind.Local), Text = "Note #3" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
