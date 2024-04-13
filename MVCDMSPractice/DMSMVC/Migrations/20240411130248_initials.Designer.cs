﻿// <auto-generated />
using System;
using DMSMVC.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DMSMVC.Migrations
{
    [DbContext(typeof(DmsContext))]
    [Migration("20240411130248_initials")]
    partial class initials
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DMSMVC.Models.Entities.Chat", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ChatReference")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ReceiverEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SenderEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.ChatContent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ChatContentReference")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ChatId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ContentOfChat")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("ChatContents");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Department", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Acronym")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HeadOfDepartmentStaffNumber")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = "9a07d60f--4930-8e8b1629",
                            Acronym = "BCK",
                            DepartmentName = "Backend"
                        });
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Document", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<string>("DepartmentId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DocumentUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("TimeUploaded")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StaffId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Staff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StaffNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            Id = "8f4667b3-9f21-42b7-80a0",
                            DepartmentId = "9a07d60f--4930-8e8b1629",
                            Level = "12",
                            Position = "Staff",
                            StaffNumber = "49419",
                            UserId = "9a07d60f--4930-8e8b1629"
                        });
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePhotoUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityAnswer")
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityQuestion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "9a07d60f--4930-8e8b1629",
                            Email = "admin@gmail.com",
                            FirstName = "admin",
                            Gender = 1,
                            LastName = "admin",
                            Password = "123456",
                            PhoneNumber = "1234567890"
                        });
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.ChatContent", b =>
                {
                    b.HasOne("DMSMVC.Models.Entities.Chat", "Chat")
                        .WithMany("ChatContents")
                        .HasForeignKey("ChatId");

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Document", b =>
                {
                    b.HasOne("DMSMVC.Models.Entities.Department", "Department")
                        .WithMany("Documents")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("DMSMVC.Models.Entities.Staff", "Staff")
                        .WithMany("Documents")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Staff", b =>
                {
                    b.HasOne("DMSMVC.Models.Entities.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DMSMVC.Models.Entities.User", "User")
                        .WithOne("Staff")
                        .HasForeignKey("DMSMVC.Models.Entities.Staff", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Chat", b =>
                {
                    b.Navigation("ChatContents");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Department", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.Staff", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("DMSMVC.Models.Entities.User", b =>
                {
                    b.Navigation("Staff");
                });
#pragma warning restore 612, 618
        }
    }
}