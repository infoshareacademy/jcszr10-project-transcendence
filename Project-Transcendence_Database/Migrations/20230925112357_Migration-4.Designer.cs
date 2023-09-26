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
    [Migration("20230925112357_Migration-4")]
    partial class Migration4
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterClassId = 1,
                            ClassType = 0,
                            Damage = 10,
                            Description = "Opis umiejętności 1",
                            Healing = 0,
                            Name = "Umiejętność 1",
                            ResourceCost = 2
                        },
                        new
                        {
                            Id = 2,
                            CharacterClassId = 1,
                            ClassType = 0,
                            Damage = 15,
                            Description = "Opis umiejętności 2",
                            Healing = 0,
                            Name = "Umiejętność 2",
                            ResourceCost = 1
                        },
                        new
                        {
                            Id = 3,
                            CharacterClassId = 1,
                            ClassType = 0,
                            Damage = 15,
                            Description = "Opis umiejętności 3",
                            Healing = 0,
                            Name = "Umiejętność 3",
                            ResourceCost = 1
                        },
                        new
                        {
                            Id = 4,
                            CharacterClassId = 1,
                            ClassType = 0,
                            Damage = 15,
                            Description = "Opis umiejętności 4",
                            Healing = 0,
                            Name = "Umiejętność 4",
                            ResourceCost = 1
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową",
                            Name = "Mnich",
                            PlayerCharacterId = 0,
                            ResourceId = 4
                        },
                        new
                        {
                            Id = 2,
                            Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową",
                            Name = "Czarodziej",
                            PlayerCharacterId = 0,
                            ResourceId = 3
                        },
                        new
                        {
                            Id = 3,
                            Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową",
                            Name = "Łotrzyk",
                            PlayerCharacterId = 0,
                            ResourceId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową",
                            Name = "Wojownik",
                            PlayerCharacterId = 0,
                            ResourceId = 2
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Zróżnicowana i wszechstronna rasa ludzi.",
                            Name = "Człowiek"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Elegancka i długo żyjąca rasa elfów.",
                            Name = "Elf"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Silni i wytrwali krasnoludy znane ze swojego rzemiosła.",
                            Name = "Krasnolud"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Groźni wojownicy orkowie znani ze swojej siły.",
                            Name = "Ork"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Małe i zwinne niziołki, mistrzowie kamuflażu.",
                            Name = "Niziołek"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Strażnicy lasów, związani z naturą.",
                            Name = "Driad"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Małe wynalazcze gnomowie, znawcy technologii.",
                            Name = "Gnom"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Potomkowie ludzi i istot boskich, posiadający boskie dziedzictwo.",
                            Name = "Aasimar"
                        });
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

                    b.Property<int?>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerCharacterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnemyId")
                        .IsUnique()
                        .HasFilter("[EnemyId] IS NOT NULL");

                    b.HasIndex("PlayerCharacterId")
                        .IsUnique()
                        .HasFilter("[PlayerCharacterId] IS NOT NULL");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Project_Transcendence_Database.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Agility")
                        .HasColumnType("int");

                    b.Property<int?>("Armor")
                        .HasColumnType("int");

                    b.Property<int?>("Damage")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Healing")
                        .HasColumnType("int");

                    b.Property<int?>("Intelect")
                        .HasColumnType("int");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<int?>("Luck")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Strength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 10,
                            Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji",
                            ItemType = 0,
                            Name = "Zwykły stalowy miecz"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 7,
                            Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji",
                            ItemType = 0,
                            Name = "Zwykły stalowy sztylet"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 5,
                            Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji",
                            ItemType = 0,
                            Name = "Zwykłe rękawice mnicha bojowego"
                        },
                        new
                        {
                            Id = 4,
                            Damage = 5,
                            Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji",
                            ItemType = 0,
                            Name = "Zwykły dębowy kostur"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał sczęście o 1",
                            ItemType = 1,
                            Luck = 2,
                            Name = "Zwykły pierścień szczęścia"
                        },
                        new
                        {
                            Id = 6,
                            Agility = 2,
                            Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał zręczność o 1",
                            ItemType = 1,
                            Name = "Zwykły pierścień zręczności"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał siłę o 1",
                            ItemType = 1,
                            Name = "Zwykły pierścień siły",
                            Strength = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększać inteligencję o 1",
                            Intelect = 2,
                            ItemType = 1,
                            Name = "Zwykły pierścień inteligencji"
                        },
                        new
                        {
                            Id = 9,
                            Agility = 1,
                            Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększać wszystkie statystyki o 1 ",
                            Intelect = 1,
                            ItemType = 1,
                            Luck = 1,
                            Name = "Magiczny pierścień",
                            Strength = 1
                        },
                        new
                        {
                            Id = 10,
                            Description = "TzewohTts elcpamw eiltr hnu'semoy",
                            ItemType = 1,
                            Luck = 100,
                            Name = "Pierścień Boga"
                        },
                        new
                        {
                            Id = 11,
                            Damage = 8,
                            Description = "Elegancki srebrny sztylet, idealny do skrytych ataków.",
                            ItemType = 0,
                            Name = "Srebrny sztylet"
                        },
                        new
                        {
                            Id = 12,
                            Damage = 12,
                            Description = "Drewniany łuk dębowy z zestawem strzał.",
                            ItemType = 0,
                            Name = "Łuk dębowy"
                        },
                        new
                        {
                            Id = 13,
                            Damage = 15,
                            Description = "Ciężki topór bojowy z masywnym ostrzem.",
                            ItemType = 0,
                            Name = "Topór bojowy"
                        },
                        new
                        {
                            Id = 14,
                            Damage = 5,
                            Description = "Różdżka wykonana z jesionu, zdolna do rzucania potężnych zaklęć.",
                            ItemType = 0,
                            Name = "Magiczny różdżka"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Naszyjnik imbued z magią, zwiększa siłę o 5",
                            ItemType = 1,
                            Name = "Naszyjnik mocy",
                            Strength = 5
                        },
                        new
                        {
                            Id = 16,
                            Description = "Perła o magicznym pochodzeniu, zwiększa inteligencję o 4",
                            Intelect = 4,
                            ItemType = 1,
                            Name = "Perła mądrości"
                        },
                        new
                        {
                            Id = 17,
                            Agility = 3,
                            Description = "Elegancka bransoletka, zwiększa zręczność o 3",
                            ItemType = 1,
                            Name = "Bransoletka zręczności"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Tajemniczy pierścień, który przynosi szczęście, zwiększa szczęście o 2",
                            ItemType = 1,
                            Luck = 2,
                            Name = "Pierścień szczęścia"
                        },
                        new
                        {
                            Id = 19,
                            Agility = 2,
                            Description = "Amulet odwagi, który zwiększa siłę o 3 i zręczność o 2",
                            ItemType = 1,
                            Name = "Amulet odwagi",
                            Strength = 3
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100,
                            MaxAmount = 100,
                            Name = "Energia"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100,
                            MaxAmount = 100,
                            Name = "Gniew"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 100,
                            MaxAmount = 100,
                            Name = "Mana"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 10,
                            MaxAmount = 10,
                            Name = "Chi"
                        });
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
                        .HasForeignKey("Project_Transcendence_Database.Entities.Inventory", "EnemyId");

                    b.HasOne("Project_Transcendence_Database.Entities.PlayerCharacter", "PlayerCharacter")
                        .WithOne("Inventory")
                        .HasForeignKey("Project_Transcendence_Database.Entities.Inventory", "PlayerCharacterId");

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

                    b.HasOne("Project_Transcendence_Database.Entities.Item", "MainHandWeapon")
                        .WithMany()
                        .HasForeignKey("MainHandWeaponId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Project_Transcendence_Database.Entities.Item", "OffHandWeapon")
                        .WithMany()
                        .HasForeignKey("OffHandWeaponId")
                        .OnDelete(DeleteBehavior.NoAction)
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
