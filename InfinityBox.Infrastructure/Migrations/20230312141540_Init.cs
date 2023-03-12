using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfinityBox.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetType = table.Column<int>(type: "INTEGER", nullable: false),
                    Duration = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatModifiers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsTarget = table.Column<bool>(type: "INTEGER", nullable: false),
                    StatType = table.Column<int>(type: "INTEGER", nullable: false),
                    CalculateType = table.Column<int>(type: "INTEGER", nullable: false),
                    Rate = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatModifiers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserBanks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Coins = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPockets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Coins = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPockets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BaseExperience = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_CharacterTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CharacterTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EffectStatModifiers",
                columns: table => new
                {
                    EffectId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatModifierId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectStatModifiers", x => new { x.EffectId, x.StatModifierId });
                    table.ForeignKey(
                        name: "FK_EffectStatModifiers_Effects_EffectId",
                        column: x => x.EffectId,
                        principalTable: "Effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectStatModifiers_StatModifiers_StatModifierId",
                        column: x => x.StatModifierId,
                        principalTable: "StatModifiers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LevelRequired = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evolutions_CharacterTypes_CharacterTypeId",
                        column: x => x.CharacterTypeId,
                        principalTable: "CharacterTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Evolutions_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Passives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passives_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cooldown = table.Column<int>(type: "INTEGER", nullable: false),
                    Power = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemType = table.Column<int>(type: "INTEGER", nullable: false),
                    EvolutionId = table.Column<int>(type: "INTEGER", nullable: true),
                    InventoryId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Evolutions_EvolutionId",
                        column: x => x.EvolutionId,
                        principalTable: "Evolutions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Items_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCharacters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    Stars = table.Column<int>(type: "INTEGER", nullable: false),
                    Experience = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    EvolutionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCharacters_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCharacters_Evolutions_EvolutionId",
                        column: x => x.EvolutionId,
                        principalTable: "Evolutions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EffectPassive",
                columns: table => new
                {
                    EffectsId = table.Column<int>(type: "INTEGER", nullable: false),
                    PassivesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectPassive", x => new { x.EffectsId, x.PassivesId });
                    table.ForeignKey(
                        name: "FK_EffectPassive_Effects_EffectsId",
                        column: x => x.EffectsId,
                        principalTable: "Effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectPassive_Passives_PassivesId",
                        column: x => x.PassivesId,
                        principalTable: "Passives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EffectSkill",
                columns: table => new
                {
                    EffectsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SkillsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectSkill", x => new { x.EffectsId, x.SkillsId });
                    table.ForeignKey(
                        name: "FK_EffectSkill_Effects_EffectsId",
                        column: x => x.EffectsId,
                        principalTable: "Effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EffectSkill_Skills_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    UserCharacterId = table.Column<Guid>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_UserCharacters_UserCharacterId",
                        column: x => x.UserCharacterId,
                        principalTable: "UserCharacters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharacterStats",
                columns: table => new
                {
                    StatId = table.Column<int>(type: "INTEGER", nullable: false),
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStats", x => new { x.CharacterId, x.StatId });
                    table.ForeignKey(
                        name: "FK_CharacterStats_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStats_Stats_StatId",
                        column: x => x.StatId,
                        principalTable: "Stats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TypeId",
                table: "Characters",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStats_StatId",
                table: "CharacterStats",
                column: "StatId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectPassive_PassivesId",
                table: "EffectPassive",
                column: "PassivesId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectSkill_SkillsId",
                table: "EffectSkill",
                column: "SkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_EffectStatModifiers_StatModifierId",
                table: "EffectStatModifiers",
                column: "StatModifierId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_CharacterId",
                table: "Evolutions",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Evolutions_CharacterTypeId",
                table: "Evolutions",
                column: "CharacterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_EvolutionId",
                table: "Items",
                column: "EvolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_InventoryId",
                table: "Items",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Passives_CharacterId",
                table: "Passives",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterId",
                table: "Skills",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_UserCharacterId",
                table: "Stats",
                column: "UserCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacters_CharacterId",
                table: "UserCharacters",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCharacters_EvolutionId",
                table: "UserCharacters",
                column: "EvolutionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterStats");

            migrationBuilder.DropTable(
                name: "EffectPassive");

            migrationBuilder.DropTable(
                name: "EffectSkill");

            migrationBuilder.DropTable(
                name: "EffectStatModifiers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "UserBanks");

            migrationBuilder.DropTable(
                name: "UserPockets");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Passives");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "StatModifiers");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "UserCharacters");

            migrationBuilder.DropTable(
                name: "Evolutions");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "CharacterTypes");
        }
    }
}
