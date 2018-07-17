﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkData.Domain.EntityFramework.EntityFramework.Contexts;

namespace WorkData.Domain.EntityFramework.Migrations
{
    [DbContext(typeof(WorkDataIdentityContext))]
    partial class WorkDataIdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkData.Domain.Permissions.Roles.BaseRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasMaxLength(128);

                    b.Property<string>("BelongUserId")
                        .HasColumnName("BelongUserId")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("CreateTime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CreateUserId")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MemberUserId")
                        .HasColumnName("MemberUserId")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("ModifierTime")
                        .HasColumnName("ModifierTime");

                    b.Property<string>("ModifierUserId")
                        .HasColumnName("ModifierUserId")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("BaseRole");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.UserRoles.UserRole", b =>
                {
                    b.Property<string>("BaseRoleId")
                        .HasColumnName("BaseRoleId")
                        .HasMaxLength(128);

                    b.Property<string>("BaseUserId")
                        .HasColumnName("BaseUserId")
                        .HasMaxLength(128);

                    b.HasKey("BaseRoleId", "BaseUserId");

                    b.HasIndex("BaseUserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.Users.BaseUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasMaxLength(128);

                    b.Property<string>("BelongUserId")
                        .HasColumnName("BelongUserId")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("CreateTime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CreateUserId")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("MemberUserId")
                        .HasColumnName("MemberUserId")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("ModifierTime")
                        .HasColumnName("ModifierTime");

                    b.Property<string>("ModifierUserId")
                        .HasColumnName("ModifierUserId")
                        .HasMaxLength(500);

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("BaseUser");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.UserRoles.UserRole", b =>
                {
                    b.HasOne("WorkData.Domain.Permissions.Roles.BaseRole", "BaseRole")
                        .WithMany("UserRoles")
                        .HasForeignKey("BaseRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkData.Domain.Permissions.Users.BaseUser", "BaseUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("BaseUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
