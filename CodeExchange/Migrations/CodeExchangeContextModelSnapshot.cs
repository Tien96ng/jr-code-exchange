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

                    b.Property<string>("IpAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rep")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AppUserId");

                    b.HasIndex("ForumId");

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

            modelBuilder.Entity("CodeExchange.Models.Forum", b =>
                {
                    b.Property<int>("ForumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ForumId");

                    b.ToTable("Forums");
                });

            modelBuilder.Entity("CodeExchange.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int?>("PostId1")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PostId");

                    b.HasIndex("PostId1");

                    b.ToTable("Posts");
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

            modelBuilder.Entity("CodeExchange.Models.Post", b =>
                {
                    b.HasOne("CodeExchange.Models.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId1");
                });

            modelBuilder.Entity("CodeExchange.Models.AppUser", b =>
                {
                    b.Navigation("JoinEntities");
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
