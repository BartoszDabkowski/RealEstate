﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RealEstate.Persistence;

namespace RealEstate.Migrations
{
    [DbContext(typeof(RealEstateDbContext))]
    [Migration("20180511192700_SeedCitiesTable")]
    partial class SeedCitiesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealEstate.Core.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountyId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CountyId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("RealEstate.Core.Models.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("RealEstate.Core.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Acres");

                    b.Property<int>("Bathrooms");

                    b.Property<int>("Bedrooms");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<bool>("HasView");

                    b.Property<bool>("HasWaterfront");

                    b.Property<int>("HouseTypeId");

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("Price");

                    b.Property<int>("SquareFootage");

                    b.HasKey("Id");

                    b.HasIndex("HouseTypeId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("RealEstate.Core.Models.HouseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("HouseType");
                });

            modelBuilder.Entity("RealEstate.Core.Models.City", b =>
                {
                    b.HasOne("RealEstate.Core.Models.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RealEstate.Core.Models.House", b =>
                {
                    b.HasOne("RealEstate.Core.Models.HouseType", "HouseType")
                        .WithMany()
                        .HasForeignKey("HouseTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("RealEstate.Core.Models.Address", "Address", b1 =>
                        {
                            b1.Property<int>("HouseId");

                            b1.Property<int>("CityId");

                            b1.Property<string>("Street");

                            b1.Property<int>("ZipCode");

                            b1.HasIndex("CityId");

                            b1.ToTable("Houses");

                            b1.HasOne("RealEstate.Core.Models.City", "City")
                                .WithMany()
                                .HasForeignKey("CityId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasOne("RealEstate.Core.Models.House")
                                .WithOne("Address")
                                .HasForeignKey("RealEstate.Core.Models.Address", "HouseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
