﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using probnik.Models;

namespace probnik.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210829092625_Logg")]
    partial class Logg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("probnik.Data.AddGroupChat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("creator");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint")
                        .HasColumnName("groupId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("GroupChat");
                });

            modelBuilder.Entity("probnik.Data.Albums", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userid");

                    b.HasKey("Id");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("probnik.Data.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Music")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("music");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("photo");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("video");

                    b.Property<int>("postId")
                        .HasColumnType("int")
                        .HasColumnName("postId");

                    b.HasKey("Id");

                    b.HasIndex("postId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("probnik.Data.Messages", b =>
                {
                    b.Property<int>("ProstoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prostoId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<string>("Fromm")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("fromm");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("photo");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("video");

                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("id");

                    b.HasKey("ProstoId");

                    b.HasIndex("id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("probnik.Data.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("photo");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.Property<int>("albumId")
                        .HasColumnType("int")
                        .HasColumnName("albumId");

                    b.HasKey("Id");

                    b.HasIndex("albumId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("probnik.Data.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("data");

                    b.Property<byte[]>("Music")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("music");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("photo");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("to");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("userid");

                    b.Property<byte[]>("Video")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("video");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("probnik.Data.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("probnik.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("probnik.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("probnik.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("probnik.Data.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("probnik.Data.AddGroupChat", b =>
                {
                    b.HasOne("probnik.Data.User", "user")
                        .WithMany("GroupChats")
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("probnik.Data.Comments", b =>
                {
                    b.HasOne("probnik.Data.Posts", "Posts")
                        .WithOne("Comments")
                        .HasForeignKey("probnik.Data.Comments", "postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("probnik.Data.Messages", b =>
                {
                    b.HasOne("probnik.Data.User", "user")
                        .WithOne("message")
                        .HasForeignKey("probnik.Data.Messages", "id");

                    b.Navigation("user");
                });

            modelBuilder.Entity("probnik.Data.Photos", b =>
                {
                    b.HasOne("probnik.Data.Albums", "albums")
                        .WithOne("Photos")
                        .HasForeignKey("probnik.Data.Photos", "albumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("albums");
                });

            modelBuilder.Entity("probnik.Data.Albums", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("probnik.Data.Posts", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("probnik.Data.User", b =>
                {
                    b.Navigation("GroupChats");

                    b.Navigation("message");
                });
#pragma warning restore 612, 618
        }
    }
}