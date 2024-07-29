﻿// <auto-generated />
using Duckeebs.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Duckeebs.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240729102501_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("Duckeebs.Core.Entities.Keycap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("KeycapSetId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("KeycapSetId");

                    b.ToTable("Keycaps");
                });

            modelBuilder.Entity("Duckeebs.Core.Entities.KeycapSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SourceUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("KeycapSets");
                });

            modelBuilder.Entity("Duckeebs.Core.Entities.Keycap", b =>
                {
                    b.HasOne("Duckeebs.Core.Entities.KeycapSet", "KeycapSet")
                        .WithMany("Keycaps")
                        .HasForeignKey("KeycapSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KeycapSet");
                });

            modelBuilder.Entity("Duckeebs.Core.Entities.KeycapSet", b =>
                {
                    b.Navigation("Keycaps");
                });
#pragma warning restore 612, 618
        }
    }
}