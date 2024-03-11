﻿// <auto-generated />
using System;
using Demo.Listings.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo.Listings.Infrastructure.Migrations
{
    [DbContext(typeof(ListingsDbContext))]
    [Migration("20240311023520_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Demo.Listings.Infrastructure.DataAccess.EF.Entities.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("Bathrooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bedrooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HalfBathrooms")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double?>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearBuilt")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Listings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "04235 Hancock Glens, South Brettmouth, CT 68377",
                            Bathrooms = 4,
                            Bedrooms = 4,
                            HalfBathrooms = 1,
                            Latitude = -40.071434000000004,
                            Longitude = 5.7012020000000003,
                            PhotoUrl = "https://example.com/photo1",
                            Price = 565231m,
                            YearBuilt = 2004
                        },
                        new
                        {
                            Id = 2,
                            Address = "42798 Nichole Branch Apt. 244, Port Philip, IN 72942",
                            Bathrooms = 2,
                            Bedrooms = 1,
                            HalfBathrooms = 2,
                            Latitude = 88.519002,
                            Longitude = 44.788677,
                            PhotoUrl = "https://example.com/photo2",
                            Price = 127932m,
                            YearBuilt = 1907
                        },
                        new
                        {
                            Id = 3,
                            Address = "79361 Salas Unions Apt. 294, Sherrihaven, MA 67529",
                            Bathrooms = 3,
                            Bedrooms = 2,
                            HalfBathrooms = 0,
                            Latitude = 56.307156999999997,
                            Longitude = -10.128527,
                            PhotoUrl = "https://example.com/photo3",
                            Price = 957331m,
                            YearBuilt = 1938
                        },
                        new
                        {
                            Id = 4,
                            Address = "6305 David Cliff, South Frank, DE 53924",
                            Bathrooms = 4,
                            Bedrooms = 5,
                            HalfBathrooms = 3,
                            Latitude = -15.923049000000001,
                            Longitude = -93.900028000000006,
                            PhotoUrl = "https://example.com/photo4",
                            Price = 637492m,
                            YearBuilt = 1900
                        },
                        new
                        {
                            Id = 5,
                            Address = "84954 Johnson Camp Suite 156, South Carol, ND 86459",
                            Bathrooms = 4,
                            Bedrooms = 1,
                            HalfBathrooms = 1,
                            Latitude = -19.518991,
                            Longitude = -8.7739170000000009,
                            PhotoUrl = "https://example.com/photo5",
                            Price = 971216m,
                            YearBuilt = 1917
                        },
                        new
                        {
                            Id = 6,
                            Address = "USNV Morgan, FPO AE 70370",
                            Bathrooms = 3,
                            Bedrooms = 3,
                            HalfBathrooms = 3,
                            Latitude = -30.447462999999999,
                            Longitude = 17.217974999999999,
                            PhotoUrl = "https://example.com/photo6",
                            Price = 697592m,
                            YearBuilt = 1997
                        },
                        new
                        {
                            Id = 7,
                            Address = "73514 Mann Estate, Paulaburgh, IL 74054",
                            Bathrooms = 5,
                            Bedrooms = 5,
                            HalfBathrooms = 0,
                            Latitude = -16.127953000000002,
                            Longitude = -154.46768800000001,
                            PhotoUrl = "https://example.com/photo7",
                            Price = 434863m,
                            YearBuilt = 2003
                        },
                        new
                        {
                            Id = 20,
                            Address = "PSC 2644, Box 4674, APO AE 52772",
                            Bathrooms = 4,
                            Bedrooms = 1,
                            HalfBathrooms = 2,
                            Latitude = -24.571092,
                            Longitude = 48.948146000000001,
                            PhotoUrl = "https://example.com/photo20",
                            Price = 350412m,
                            YearBuilt = 1942
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
