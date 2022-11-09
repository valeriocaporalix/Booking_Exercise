﻿// <auto-generated />
using System;
using Booking_Exercise.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Booking_Exercise.Migrations
{
    [DbContext(typeof(BookingDbContext))]
    partial class BookingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Booking_Exercise.Models.BookingModels.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<DateTime>("EndBooking")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartBooking")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Booking_Exercise.Models.HotelModels.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = 11,
                            Address = "Via Test 10",
                            Name = "Hotel TestOne"
                        },
                        new
                        {
                            HotelId = 12,
                            Address = "Via Test 10",
                            Name = "Hotel TestTwo"
                        },
                        new
                        {
                            HotelId = 13,
                            Address = "Via Test 10",
                            Name = "Hotel TestThree"
                        },
                        new
                        {
                            HotelId = 14,
                            Address = "Via Test 10",
                            Name = "Hotel TestFour"
                        },
                        new
                        {
                            HotelId = 15,
                            Address = "Via Test 10",
                            Name = "Hotel TestFive"
                        },
                        new
                        {
                            HotelId = 16,
                            Address = "Via Test 10",
                            Name = "Hotel TestSix"
                        },
                        new
                        {
                            HotelId = 17,
                            Address = "Via Test 10",
                            Name = "Hotel TestSeven"
                        },
                        new
                        {
                            HotelId = 18,
                            Address = "Via Test 10",
                            Name = "Hotel TestEight"
                        },
                        new
                        {
                            HotelId = 19,
                            Address = "Via Test 10",
                            Name = "Hotel TestNine"
                        },
                        new
                        {
                            HotelId = 20,
                            Address = "Via Test 10",
                            Name = "Hotel TestTen"
                        });
                });

            modelBuilder.Entity("Booking_Exercise.Models.RatingModels.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("RangeRating")
                        .HasColumnType("int");

                    b.HasKey("RatingId");

                    b.HasIndex("HotelId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Booking_Exercise.Models.RoomModels.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("RoomCapacity")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Booking_Exercise.Models.UserModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("CreditCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiscalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookingRoom", b =>
                {
                    b.Property<int>("BookingsBookingId")
                        .HasColumnType("int");

                    b.Property<int>("RoomsRoomId")
                        .HasColumnType("int");

                    b.HasKey("BookingsBookingId", "RoomsRoomId");

                    b.HasIndex("RoomsRoomId");

                    b.ToTable("BookingRoom");
                });

            modelBuilder.Entity("Booking_Exercise.Models.BookingModels.Booking", b =>
                {
                    b.HasOne("Booking_Exercise.Models.UserModels.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Booking_Exercise.Models.RatingModels.Rating", b =>
                {
                    b.HasOne("Booking_Exercise.Models.HotelModels.Hotel", "Hotel")
                        .WithMany("Ratings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("Booking_Exercise.Models.RoomModels.Room", b =>
                {
                    b.HasOne("Booking_Exercise.Models.HotelModels.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingRoom", b =>
                {
                    b.HasOne("Booking_Exercise.Models.BookingModels.Booking", null)
                        .WithMany()
                        .HasForeignKey("BookingsBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Booking_Exercise.Models.RoomModels.Room", null)
                        .WithMany()
                        .HasForeignKey("RoomsRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Booking_Exercise.Models.HotelModels.Hotel", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Booking_Exercise.Models.UserModels.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
