﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission10.Data;

#nullable disable

namespace Mission10.Migrations
{
    [DbContext(typeof(BowlerContext))]
    [Migration("20240315175656_FirstOne")]
    partial class FirstOne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Mission10.Data.Bowler", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerID");

                    b.HasIndex("TeamID");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("Mission10.Data.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Mission10.Data.Bowler", b =>
                {
                    b.HasOne("Mission10.Data.Team", "TeamName")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamName");
                });
#pragma warning restore 612, 618
        }
    }
}
