﻿// <auto-generated />
using DataClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLibrary.Migrations
{
    [DbContext(typeof(GuildDatabase))]
    partial class GuildDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataModels.GuildRank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GuildRankName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("GuildRanks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GuildRankName = "Guild Master"
                        },
                        new
                        {
                            Id = 2,
                            GuildRankName = "Officer"
                        },
                        new
                        {
                            Id = 3,
                            GuildRankName = "Member"
                        },
                        new
                        {
                            Id = 4,
                            GuildRankName = "Trial"
                        });
                });

            modelBuilder.Entity("DataModels.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GuildRankID")
                        .HasColumnType("int");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("PlayerRole")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("WowClassID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuildRankID");

                    b.HasIndex("TeamID");

                    b.HasIndex("WowClassID");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GuildRankID = 1,
                            PlayerName = "Heterohexual",
                            PlayerRole = "Melee DPS",
                            Specialization = "Enhancement",
                            TeamID = 1,
                            WowClassID = 10
                        });
                });

            modelBuilder.Entity("DataModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Tank"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "Healer"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "Melee DPS"
                        },
                        new
                        {
                            Id = 4,
                            RoleName = "Ranged DPS"
                        });
                });

            modelBuilder.Entity("DataModels.Spec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SpecName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("WowClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("WowClassId");

                    b.ToTable("Specs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            SpecName = "Blood",
                            WowClassId = 1
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 3,
                            SpecName = "Frost",
                            WowClassId = 1
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 3,
                            SpecName = "Blood",
                            WowClassId = 1
                        },
                        new
                        {
                            Id = 4,
                            RoleId = 1,
                            SpecName = "Vengeance",
                            WowClassId = 2
                        },
                        new
                        {
                            Id = 5,
                            RoleId = 3,
                            SpecName = "Havoc",
                            WowClassId = 2
                        },
                        new
                        {
                            Id = 6,
                            RoleId = 1,
                            SpecName = "Guardian",
                            WowClassId = 3
                        },
                        new
                        {
                            Id = 7,
                            RoleId = 2,
                            SpecName = "Restoration",
                            WowClassId = 3
                        },
                        new
                        {
                            Id = 8,
                            RoleId = 3,
                            SpecName = "Feral",
                            WowClassId = 3
                        },
                        new
                        {
                            Id = 9,
                            RoleId = 4,
                            SpecName = "Balance",
                            WowClassId = 3
                        },
                        new
                        {
                            Id = 10,
                            RoleId = 3,
                            SpecName = "Survival",
                            WowClassId = 4
                        },
                        new
                        {
                            Id = 11,
                            RoleId = 4,
                            SpecName = "Beast Mastery",
                            WowClassId = 4
                        },
                        new
                        {
                            Id = 12,
                            RoleId = 4,
                            SpecName = "Marksmanship",
                            WowClassId = 4
                        },
                        new
                        {
                            Id = 13,
                            RoleId = 4,
                            SpecName = "Fire",
                            WowClassId = 5
                        },
                        new
                        {
                            Id = 14,
                            RoleId = 4,
                            SpecName = "Frost",
                            WowClassId = 5
                        },
                        new
                        {
                            Id = 15,
                            RoleId = 4,
                            SpecName = "Arcane",
                            WowClassId = 5
                        },
                        new
                        {
                            Id = 16,
                            RoleId = 1,
                            SpecName = "Brewmaster",
                            WowClassId = 6
                        },
                        new
                        {
                            Id = 17,
                            RoleId = 2,
                            SpecName = "Mistweaver",
                            WowClassId = 6
                        },
                        new
                        {
                            Id = 18,
                            RoleId = 3,
                            SpecName = "Windwalker",
                            WowClassId = 6
                        },
                        new
                        {
                            Id = 19,
                            RoleId = 1,
                            SpecName = "Protection",
                            WowClassId = 7
                        },
                        new
                        {
                            Id = 20,
                            RoleId = 2,
                            SpecName = "Holy",
                            WowClassId = 7
                        },
                        new
                        {
                            Id = 21,
                            RoleId = 3,
                            SpecName = "Retribution",
                            WowClassId = 7
                        },
                        new
                        {
                            Id = 22,
                            RoleId = 2,
                            SpecName = "Discipline",
                            WowClassId = 8
                        },
                        new
                        {
                            Id = 23,
                            RoleId = 2,
                            SpecName = "Holy",
                            WowClassId = 8
                        },
                        new
                        {
                            Id = 24,
                            RoleId = 4,
                            SpecName = "Shadow",
                            WowClassId = 8
                        },
                        new
                        {
                            Id = 25,
                            RoleId = 3,
                            SpecName = "Outlaw",
                            WowClassId = 9
                        },
                        new
                        {
                            Id = 26,
                            RoleId = 3,
                            SpecName = "Subtlety",
                            WowClassId = 9
                        },
                        new
                        {
                            Id = 27,
                            RoleId = 3,
                            SpecName = "Assassination",
                            WowClassId = 9
                        },
                        new
                        {
                            Id = 28,
                            RoleId = 2,
                            SpecName = "Restoration",
                            WowClassId = 10
                        },
                        new
                        {
                            Id = 29,
                            RoleId = 3,
                            SpecName = "Enhancement",
                            WowClassId = 10
                        },
                        new
                        {
                            Id = 30,
                            RoleId = 4,
                            SpecName = "Elemental",
                            WowClassId = 10
                        },
                        new
                        {
                            Id = 31,
                            RoleId = 4,
                            SpecName = "Destruction",
                            WowClassId = 11
                        },
                        new
                        {
                            Id = 32,
                            RoleId = 4,
                            SpecName = "Demonology",
                            WowClassId = 11
                        },
                        new
                        {
                            Id = 33,
                            RoleId = 4,
                            SpecName = "Affliction",
                            WowClassId = 11
                        },
                        new
                        {
                            Id = 34,
                            RoleId = 1,
                            SpecName = "Protection",
                            WowClassId = 12
                        },
                        new
                        {
                            Id = 35,
                            RoleId = 3,
                            SpecName = "Fury",
                            WowClassId = 12
                        },
                        new
                        {
                            Id = 36,
                            RoleId = 3,
                            SpecName = "Arms",
                            WowClassId = 12
                        });
                });

            modelBuilder.Entity("DataModels.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeamName = "Mythic Raiding"
                        },
                        new
                        {
                            Id = 2,
                            TeamName = "M+ Team One"
                        });
                });

            modelBuilder.Entity("DataModels.WowClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClassName = "Death Knight"
                        },
                        new
                        {
                            Id = 2,
                            ClassName = "Demon Hunter"
                        },
                        new
                        {
                            Id = 3,
                            ClassName = "Druid"
                        },
                        new
                        {
                            Id = 4,
                            ClassName = "Hunter"
                        },
                        new
                        {
                            Id = 5,
                            ClassName = "Mage"
                        },
                        new
                        {
                            Id = 6,
                            ClassName = "Monk"
                        },
                        new
                        {
                            Id = 7,
                            ClassName = "Paladin"
                        },
                        new
                        {
                            Id = 8,
                            ClassName = "Priest"
                        },
                        new
                        {
                            Id = 9,
                            ClassName = "Rogue"
                        },
                        new
                        {
                            Id = 10,
                            ClassName = "Shaman"
                        },
                        new
                        {
                            Id = 11,
                            ClassName = "Warlock"
                        },
                        new
                        {
                            Id = 12,
                            ClassName = "Warrior"
                        });
                });

            modelBuilder.Entity("DataModels.Player", b =>
                {
                    b.HasOne("DataModels.GuildRank", "GuildRank")
                        .WithMany("Players")
                        .HasForeignKey("GuildRankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModels.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModels.WowClass", "WowClass")
                        .WithMany("Player")
                        .HasForeignKey("WowClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GuildRank");

                    b.Navigation("Team");

                    b.Navigation("WowClass");
                });

            modelBuilder.Entity("DataModels.Spec", b =>
                {
                    b.HasOne("DataModels.Role", "Role")
                        .WithMany("Specs")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataModels.WowClass", "WowClass")
                        .WithMany("Spec")
                        .HasForeignKey("WowClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("WowClass");
                });

            modelBuilder.Entity("DataModels.GuildRank", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("DataModels.Role", b =>
                {
                    b.Navigation("Specs");
                });

            modelBuilder.Entity("DataModels.Team", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("DataModels.WowClass", b =>
                {
                    b.Navigation("Player");

                    b.Navigation("Spec");
                });
#pragma warning restore 612, 618
        }
    }
}
