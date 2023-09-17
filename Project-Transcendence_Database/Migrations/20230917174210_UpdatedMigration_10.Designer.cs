﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Transcendence_Database.DataAccess;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230917174210_UpdatedMigration_10")]
    partial class UpdatedMigration_10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AbilityEnemy", b =>
                {
                    b.Property<int>("AbilitiesId")
                        .HasColumnType("int");

                    b.Property<int>("EnemiesId")
                        .HasColumnType("int");

                    b.HasKey("AbilitiesId", "EnemiesId");

                    b.HasIndex("EnemiesId");

                    b.ToTable("AbilityEnemy");
                });

            modelBuilder.Entity("EnemyEnemyDungeon", b =>
                {
                    b.Property<int>("EnemyDungeonsId")
                        .HasColumnType("int");

                    b.Property<int>("EnemyInDungeonId")
                        .HasColumnType("int");

                    b.HasKey("EnemyDungeonsId", "EnemyInDungeonId");

                    b.HasIndex("EnemyInDungeonId");

                    b.ToTable("EnemyEnemyDungeon");
                });

            modelBuilder.Entity("InventoryItem", b =>
                {
                    b.Property<int>("InventoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.HasKey("InventoriesId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharacterClassId")
                        .HasColumnType("int");

                    b.Property<int>("ClassType")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Healing")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResourceCost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterClassId");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.CharacterClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ResourceId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.CharacterRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Enemy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Enemies");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.EnemyDungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DungeonLevel")
                        .HasColumnType("int");

                    b.Property<string>("DungeonStory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DungeonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EnemyDungeons");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.EquipedJewelery", b =>
                {
                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("PlayerCharacterId", "ItemId");

                    b.ToTable("EquipedJeweleries");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerCharacterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnemyId")
                        .IsUnique();

                    b.HasIndex("PlayerCharacterId")
                        .IsUnique();

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("Armor")
                        .HasColumnType("int");

                    b.Property<int>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Healing")
                        .HasColumnType("int");

                    b.Property<int>("Intelect")
                        .HasColumnType("int");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<int>("Luck")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.PlayerCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("CharacterClassId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterRaceId")
                        .HasColumnType("int");

                    b.Property<int>("Expirience")
                        .HasColumnType("int");

                    b.Property<int>("FinishedDungeonIndex")
                        .HasColumnType("int");

                    b.Property<int>("Intelect")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Luck")
                        .HasColumnType("int");

                    b.Property<int?>("MainHandWeaponId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OffHandWeaponId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterClassId");

                    b.HasIndex("CharacterRaceId");

                    b.HasIndex("ItemId");

                    b.HasIndex("MainHandWeaponId");

                    b.HasIndex("OffHandWeaponId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.PuzzleDungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DungeonLevel")
                        .HasColumnType("int");

                    b.Property<string>("DungeonStory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DungeonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PuzzleDungeons");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.ShopDungeon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DungeonLevel")
                        .HasColumnType("int");

                    b.Property<string>("DungeonStory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DungeonType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShopDungeons");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AbilityEnemy", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.Ability", null)
                        .WithMany()
                        .HasForeignKey("AbilitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Enemy", null)
                        .WithMany()
                        .HasForeignKey("EnemiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnemyEnemyDungeon", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.EnemyDungeon", null)
                        .WithMany()
                        .HasForeignKey("EnemyDungeonsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Enemy", null)
                        .WithMany()
                        .HasForeignKey("EnemyInDungeonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryItem", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.Inventory", null)
                        .WithMany()
                        .HasForeignKey("InventoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Ability", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.CharacterClass", "CharacterClass")
                        .WithMany("Ability")
                        .HasForeignKey("CharacterClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharacterClass");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.CharacterClass", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.Resource", "Resource")
                        .WithMany("CharacterClass")
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resource");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Enemy", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.CharacterRace", "Race")
                        .WithMany("Enemies")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.EquipedJewelery", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.PlayerCharacter", null)
                        .WithMany("Jewelery")
                        .HasForeignKey("PlayerCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Inventory", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.Enemy", "Enemy")
                        .WithOne("Inventory")
                        .HasForeignKey("Project_Transcendence_Database.Entities.Inventory", "EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.PlayerCharacter", "PlayerCharacter")
                        .WithOne("Inventory")
                        .HasForeignKey("Project_Transcendence_Database.Entities.Inventory", "PlayerCharacterId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("PlayerCharacter");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.PlayerCharacter", b =>
                {
                    b.HasOne("Project_Transcendence_Database.Entities.CharacterClass", "CharacterClass")
                        .WithMany("PlayerCharacter")
                        .HasForeignKey("CharacterClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.CharacterRace", "CharacterRace")
                        .WithMany("Characters")
                        .HasForeignKey("CharacterRaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Item", null)
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Project_Transcendence_Database.Entities.Item", "MainHandWeapon")
                        .WithMany()
                        .HasForeignKey("MainHandWeaponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Item", "OffHandWeapon")
                        .WithMany()
                        .HasForeignKey("OffHandWeaponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.User", "User")
                        .WithOne("Character")
                        .HasForeignKey("Project_Transcendence_Database.Entities.PlayerCharacter", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CharacterClass");

                    b.Navigation("CharacterRace");

                    b.Navigation("MainHandWeapon");

                    b.Navigation("OffHandWeapon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.CharacterClass", b =>
                {
                    b.Navigation("Ability");

                    b.Navigation("PlayerCharacter");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.CharacterRace", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Enemies");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Enemy", b =>
                {
                    b.Navigation("Inventory")
                        .IsRequired();
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.PlayerCharacter", b =>
                {
                    b.Navigation("Inventory")
                        .IsRequired();

                    b.Navigation("Jewelery");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Resource", b =>
                {
                    b.Navigation("CharacterClass");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.User", b =>
                {
                    b.Navigation("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
