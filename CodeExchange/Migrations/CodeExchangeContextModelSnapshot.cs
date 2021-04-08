﻿// <auto-generated />
using System;
using CodeExchange.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeExchange.Migrations
{
    [DbContext(typeof(CodeExchangeContext))]
    partial class CodeExchangeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AppUserAppUser", b =>
                {
                    b.Property<int>("UserFollowersAppUserId")
                        .HasColumnType("int");

                    b.Property<int>("UserFollowingAppUserId")
                        .HasColumnType("int");

                    b.HasKey("UserFollowersAppUserId", "UserFollowingAppUserId");

                    b.HasIndex("UserFollowingAppUserId");

                    b.ToTable("AppUserAppUser");
                });

            modelBuilder.Entity("CodeExchange.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("ForumId")
                        .HasColumnType("int");

                    b.Property<string>("GitHub")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rep")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AppUserId");

                    b.HasIndex("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("CodeExchange.Models.AppUserForumPost", b =>
                {
                    b.Property<int>("AppUserForumPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("ForumId")
                        .HasColumnType("int");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("AppUserForumPostId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ForumId");

                    b.HasIndex("PostId");

                    b.ToTable("AppUserForumPost");
                });

            modelBuilder.Entity("CodeExchange.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("CodeExchange.Models.Forum", b =>
                {
                    b.Property<int>("ForumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("ForumId");

                    b.HasIndex("UserId");

                    b.ToTable("Forums");

                    b.HasData(
                        new
                        {
                            ForumId = 1,
                            IsVisible = false,
                            Name = "Java Sukz"
                        },
                        new
                        {
                            ForumId = 2,
                            IsVisible = false,
                            Name = "Python Rules"
                        });
                });

            modelBuilder.Entity("CodeExchange.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int?>("AppUserId1")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Creator")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int?>("PostId1")
                        .HasColumnType("int");

                    b.Property<string>("Preview")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("PostId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("AppUserId1");

                    b.HasIndex("PostId1");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            CreationDate = new DateTime(2021, 4, 7, 21, 34, 21, 48, DateTimeKind.Local).AddTicks(9557),
                            Creator = "Uncle Daniel",
                            CreatorId = 1,
                            Dislikes = 0,
                            IsVisible = true,
                            Likes = 2,
                            Title = "Python Sucks"
                        },
                        new
                        {
                            PostId = 2,
                            Content = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure",
                            CreationDate = new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(41),
                            Creator = "Uncle Tien",
                            CreatorId = 2,
                            Dislikes = 0,
                            IsVisible = true,
                            Likes = 100,
                            Title = "Swift Sucks"
                        },
                        new
                        {
                            PostId = 3,
                            Content = "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain.",
                            CreationDate = new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(49),
                            Creator = "Uncle Mikey",
                            CreatorId = 3,
                            Dislikes = 0,
                            IsVisible = true,
                            Likes = 3,
                            Title = "C# Sucks"
                        },
                        new
                        {
                            PostId = 4,
                            Content = "Here's a post",
                            CreationDate = new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(57),
                            Creator = "John",
                            CreatorId = 4,
                            Dislikes = 0,
                            IsVisible = true,
                            Likes = 9,
                            Title = "Java Sucks"
                        },
                        new
                        {
                            PostId = 5,
                            Content = "I would upload an image here if I had that functionality",
                            CreationDate = new DateTime(2021, 4, 7, 16, 34, 21, 49, DateTimeKind.Local).AddTicks(64),
                            Creator = "Lol2",
                            CreatorId = 1,
                            Dislikes = 10,
                            IsVisible = true,
                            Likes = 0,
                            Title = "JavaScript Sucks"
                        });
                });

            modelBuilder.Entity("AppUserAppUser", b =>
                {
                    b.HasOne("CodeExchange.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserFollowersAppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeExchange.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserFollowingAppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CodeExchange.Models.AppUser", b =>
                {
                    b.HasOne("CodeExchange.Models.Forum", null)
                        .WithMany("ForumFollowers")
                        .HasForeignKey("ForumId");

                    b.HasOne("CodeExchange.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeExchange.Models.AppUserForumPost", b =>
                {
                    b.HasOne("CodeExchange.Models.AppUser", "AppUser")
                        .WithMany("JoinEntities")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeExchange.Models.Forum", "Forum")
                        .WithMany("JoinEntities")
                        .HasForeignKey("ForumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeExchange.Models.Post", "Post")
                        .WithMany("JoinEntities")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Forum");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("CodeExchange.Models.Forum", b =>
                {
                    b.HasOne("CodeExchange.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeExchange.Models.Post", b =>
                {
                    b.HasOne("CodeExchange.Models.AppUser", null)
                        .WithMany("Dislikes")
                        .HasForeignKey("AppUserId");

                    b.HasOne("CodeExchange.Models.AppUser", null)
                        .WithMany("Likes")
                        .HasForeignKey("AppUserId1");

                    b.HasOne("CodeExchange.Models.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId1");

                    b.HasOne("CodeExchange.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodeExchange.Models.AppUser", b =>
                {
                    b.Navigation("Dislikes");

                    b.Navigation("JoinEntities");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("CodeExchange.Models.Forum", b =>
                {
                    b.Navigation("ForumFollowers");

                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("CodeExchange.Models.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
