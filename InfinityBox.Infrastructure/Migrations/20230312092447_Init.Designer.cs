﻿// <auto-generated />
using System;
using InfinityBox.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfinityBox.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230312092447_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("InfinityBox.Domain.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseExperience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.CharacterStat", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId", "StatId");

                    b.HasIndex("StatId");

                    b.ToTable("CharacterStats");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.CharacterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CharacterTypes");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Effect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PassiveId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SkillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PassiveId");

                    b.HasIndex("SkillId");

                    b.ToTable("Effects");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.EffectStatModifier", b =>
                {
                    b.Property<int>("EffectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatModifierId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("EffectId", "StatModifierId");

                    b.HasIndex("StatModifierId");

                    b.ToTable("EffectStatModifiers");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Evolution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("LevelRequired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("CharacterTypeId");

                    b.ToTable("Evolutions");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EvolutionId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EvolutionId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Passive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Passives");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cooldown")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Stat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("UserCharacterId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserCharacterId");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.StatModifier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalculateType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTarget")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Rate")
                        .HasColumnType("REAL");

                    b.Property<int>("StatType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("StatModifiers");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.StatRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Rate")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("StatRates");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.UserBank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Coins")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserBanks");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.UserCharacter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EvolutionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("EvolutionId");

                    b.ToTable("UserCharacters");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.UserPocket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Coins")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserPockets");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Character", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.CharacterType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.CharacterStat", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Character", "Character")
                        .WithMany("CharacterStats")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfinityBox.Domain.Entities.Stat", "Stat")
                        .WithMany("CharacterStats")
                        .HasForeignKey("StatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Stat");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Effect", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Passive", null)
                        .WithMany("Effects")
                        .HasForeignKey("PassiveId");

                    b.HasOne("InfinityBox.Domain.Entities.Skill", null)
                        .WithMany("Effects")
                        .HasForeignKey("SkillId");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.EffectStatModifier", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Effect", "Effect")
                        .WithMany("EffectStatModifiers")
                        .HasForeignKey("EffectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfinityBox.Domain.Entities.StatModifier", "StatModifier")
                        .WithMany("EffectStatModifiers")
                        .HasForeignKey("StatModifierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Effect");

                    b.Navigation("StatModifier");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Evolution", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Character", null)
                        .WithMany("Evolutions")
                        .HasForeignKey("CharacterId");

                    b.HasOne("InfinityBox.Domain.Entities.CharacterType", "CharacterType")
                        .WithMany()
                        .HasForeignKey("CharacterTypeId");

                    b.Navigation("CharacterType");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Item", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Evolution", null)
                        .WithMany("Materials")
                        .HasForeignKey("EvolutionId");

                    b.HasOne("InfinityBox.Domain.Entities.Inventory", null)
                        .WithMany("Items")
                        .HasForeignKey("InventoryId");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Passive", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Character", null)
                        .WithMany("Passives")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Skill", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Character", null)
                        .WithMany("Skills")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Stat", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.UserCharacter", null)
                        .WithMany("Stats")
                        .HasForeignKey("UserCharacterId");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.UserCharacter", b =>
                {
                    b.HasOne("InfinityBox.Domain.Entities.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfinityBox.Domain.Entities.Evolution", "Evolution")
                        .WithMany()
                        .HasForeignKey("EvolutionId");

                    b.Navigation("Character");

                    b.Navigation("Evolution");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Character", b =>
                {
                    b.Navigation("CharacterStats");

                    b.Navigation("Evolutions");

                    b.Navigation("Passives");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Effect", b =>
                {
                    b.Navigation("EffectStatModifiers");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Evolution", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Inventory", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Passive", b =>
                {
                    b.Navigation("Effects");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Skill", b =>
                {
                    b.Navigation("Effects");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.Stat", b =>
                {
                    b.Navigation("CharacterStats");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.StatModifier", b =>
                {
                    b.Navigation("EffectStatModifiers");
                });

            modelBuilder.Entity("InfinityBox.Domain.Entities.UserCharacter", b =>
                {
                    b.Navigation("Stats");
                });
#pragma warning restore 612, 618
        }
    }
}