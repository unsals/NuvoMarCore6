﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20211218220924_mig5")]
    partial class mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Port", b =>
                {
                    b.Property<int>("PortId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PortId"), 1L, 1);

                    b.Property<string>("PortCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PortCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PortDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PortName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PortUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PortId");

                    b.ToTable("Ports");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ship", b =>
                {
                    b.Property<int>("ShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShipId"), 1L, 1);

                    b.Property<DateTime?>("ShipCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ShipDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ShipStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ShipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ShipUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ShipId");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Voyage", b =>
                {
                    b.Property<int>("VoyageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoyageId"), 1L, 1);

                    b.Property<int?>("PortId")
                        .HasColumnType("int");

                    b.Property<int?>("ShipId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VoyageArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VoyageCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VoyageDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VoyageDepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VoyageUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VoyageId");

                    b.HasIndex("PortId");

                    b.HasIndex("ShipId");

                    b.ToTable("Voyages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Voyage", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Port", "Port")
                        .WithMany("Voyages")
                        .HasForeignKey("PortId");

                    b.HasOne("EntityLayer.Concrete.Ship", "Ship")
                        .WithMany("Voyages")
                        .HasForeignKey("ShipId");

                    b.Navigation("Port");

                    b.Navigation("Ship");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Port", b =>
                {
                    b.Navigation("Voyages");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ship", b =>
                {
                    b.Navigation("Voyages");
                });
#pragma warning restore 612, 618
        }
    }
}