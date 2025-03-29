//Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

namespace clashProgress
{
    public class AirBomb
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class AirDefense
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class AirSweeper
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class ArcherPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class ArcherQueen
    {
        [JsonProperty("Archer Puppet")]
        public List<ArcherPuppet>? ArcherPuppet { get; set; }

        [JsonProperty("Invisibility Vial")]
        public List<InvisibilityVial>? InvisibilityVial { get; set; }

        [JsonProperty("Giant Arrow")]
        public List<GiantArrow>? GiantArrow { get; set; }

        [JsonProperty("Healer Puppet")]
        public List<HealerPuppet>? HealerPuppet { get; set; }

        [JsonProperty("Magic Mirror")]
        public List<MagicMirror>? MagicMirror { get; set; }

        [JsonProperty("Frozen Arrow")]
        public List<FrozenArrow>? FrozenArrow { get; set; }
    }

    public class ArcherTower
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Army
    {
        public List<Barrack>? Barracks { get; set; }

        [JsonProperty("Dark Barracks")]
        public List<DarkBarrack>? DarkBarracks { get; set; }

        [JsonProperty("Spell Factory")]
        public List<SpellFactory>? SpellFactory { get; set; }

        [JsonProperty("Dark Spell Factory")]
        public List<DarkSpellFactory>? DarkSpellFactory { get; set; }
        public List<Workshop>? Workshop { get; set; }
        public List<Laboratory>? Laboratory { get; set; }

        [JsonProperty("Army Camp")]
        public List<ArmyCamp>? ArmyCamp { get; set; }

        [JsonProperty("Hero Hall")]
        public List<HeroHall>? HeroHall { get; set; }

        [JsonProperty("Pet House")]
        public List<PetHouse>? PetHouse { get; set; }
        public List<Blacksmith>? Blacksmith { get; set; }

        [JsonProperty("Clan Castle")]
        public List<ClanCastle>? ClanCastle { get; set; }
    }

    public class ArmyCamp
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class BarbarianKing
    {
        [JsonProperty("Barbarian Puppet")]
        public List<BarbarianPuppet>? BarbarianPuppet { get; set; }

        [JsonProperty("Rage Vial")]
        public List<RageVial>? RageVial { get; set; }

        [JsonProperty("Earthquake Boots")]
        public List<EarthquakeBoot>? EarthquakeBoots { get; set; }

        [JsonProperty("Vampire Stache")]
        public List<VampireStache>? VampireStache { get; set; }

        [JsonProperty("Giant Gauntlet")]
        public List<GiantGauntlet>? GiantGauntlet { get; set; }

        [JsonProperty("Spikey Ball")]
        public List<SpikeyBall>? SpikeyBall { get; set; }

        [JsonProperty("Snake Bracelet")]
        public List<SnakeBracelet>? SnakeBracelet { get; set; }
    }

    public class BarbarianPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Barrack
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Blacksmith
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Bomb
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class BombTower
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class BuilderSHut
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Buildings
    {
        public Defense? Defense { get; set; }
        public Army? Army { get; set; }
        public Resource? Resource { get; set; }
        public Traps? Traps { get; set; }
        public Support? Support { get; set; }
    }

    public class Cannon
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class ClanCastle
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class DarkBarrack
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class DarkElixirCollector
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class DarkElixirSpells
    {
        public int? Poison { get; set; }
        public int? Earthquake { get; set; }
        public int? Haste { get; set; }
        public int? Skeleton { get; set; }
        public int? Bat { get; set; }
        public int? Overgrowth { get; set; }
    }

    public class DarkElixirStorage
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class DarkElixirTroops
    {
        public int? Minion { get; set; }

        [JsonProperty("Hog Rider")]
        public int? HogRider { get; set; }
        public int? Valkyrie { get; set; }
        public int? Golem { get; set; }
        public int? Witch { get; set; }

        [JsonProperty("Lava Hound")]
        public int? LavaHound { get; set; }
        public int? Bowler { get; set; }

        [JsonProperty("Ice Golem")]
        public int? IceGolem { get; set; }

        [JsonProperty("Head Hunter")]
        public int? HeadHunter { get; set; }

        [JsonProperty("Apprentice Warden")]
        public int? ApprenticeWarden { get; set; }
        public int? Druid { get; set; }
    }

    public class DarkOrb
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class DarkSpellFactory
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Defense
    {
        public List<Cannon>? Cannons { get; set; }

        [JsonProperty("Archer Towers")]
        public List<ArcherTower>? ArcherTowers { get; set; }

        [JsonProperty("Wizard Towers")]
        public List<WizardTower>? WizardTowers { get; set; }
        public List<Mortar>? Mortars { get; set; }

        [JsonProperty("Air Defense")]
        public List<AirDefense>? AirDefense { get; set; }

        [JsonProperty("Bomb Tower")]
        public List<BombTower>? BombTower { get; set; }

        [JsonProperty("Inferno Towers")]
        public List<InfernoTower>? InfernoTowers { get; set; }

        [JsonProperty("X-Bows")]
        public List<XBow>? XBows { get; set; }

        [JsonProperty("Builder's Hut")]
        public List<BuilderSHut>? BuildersHut { get; set; }
        public List<Scattershot>? Scattershot { get; set; }

        [JsonProperty("Eagle Artillery")]
        public List<EagleArtillery>? EagleArtillery { get; set; }
        public List<Mortar>? Mortar { get; set; }

        [JsonProperty("Air Sweeper")]
        public List<AirSweeper>? AirSweeper { get; set; }
    }

    public class EagleArtillery
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class EarthquakeBoot
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class ElectroBoot
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class ElixirCollector
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class ElixirSpells
    {
        public int? Lightning { get; set; }
        public int? Healing { get; set; }
        public int? Rage { get; set; }
        public int? Jump { get; set; }
        public int? Clone { get; set; }
        public int? Freeze { get; set; }
        public int? Invisibility { get; set; }
        public int? Recall { get; set; }
        public int? Revive { get; set; }
    }

    public class ElixirStorage
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class ElixirTroops
    {
        public int? Barbarian { get; set; }
        public int? Archer { get; set; }
        public int? Giant { get; set; }
        public int? Goblin { get; set; }

        [JsonProperty("Wall Breaker")]
        public int? WallBreaker { get; set; }
        public int? Balloon { get; set; }
        public int? Wizard { get; set; }
        public int? Healer { get; set; }
        public int? Dragon { get; set; }

        [JsonProperty("P.E.K.K.A")]
        public int? PEKKA { get; set; }

        [JsonProperty("Baby Dragon")]
        public int? BabyDragon { get; set; }
        public int? Miner { get; set; }

        [JsonProperty("Electro Dragon")]
        public int? ElectroDragon { get; set; }
        public int? Yeti { get; set; }

        [JsonProperty("Electro Titan")]
        public int? ElectroTitan { get; set; }

        [JsonProperty("Root Rider")]
        public int? RootRider { get; set; }
        public int? Thrower { get; set; }
    }

    public class EternalTome
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Fireball
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class FrozenArrow
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class GiantArrow
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class GiantBomb
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class GiantGauntlet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class GoldMine
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class GoldStorage
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class GrandWarden
    {
        [JsonProperty("Eternal Tome")]
        public List<EternalTome>? EternalTome { get; set; }

        [JsonProperty("Life Gem")]
        public List<LifeGem>? LifeGem { get; set; }

        [JsonProperty("Healing Tome")]
        public List<HealingTome>? HealingTome { get; set; }

        [JsonProperty("Rage Gem")]
        public List<RageGem>? RageGem { get; set; }

        [JsonProperty("Lavaloon Puppet")]
        public List<LavaloonPuppet>? LavaloonPuppet { get; set; }
        public List<Fireball>? Fireball { get; set; }
    }

    public class HasteVial
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class HealerPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class HealingTome
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class HelperHut
    {
        public int? Builder { get; set; }
        public int? Lab { get; set; }
        public int? Alchemist { get; set; }
    }

    public class HenchmenPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class HeroEquipment
    {
        [JsonProperty("Barbarian King")]
        public BarbarianKing? BarbarianKing { get; set; }

        [JsonProperty("Archer Queen")]
        public ArcherQueen? ArcherQueen { get; set; }

        [JsonProperty("Minion Prince")]
        public MinionPrince? MinionPrince { get; set; }

        [JsonProperty("Grand Warden")]
        public GrandWarden? GrandWarden { get; set; }

        [JsonProperty("Royal Champion")]
        public RoyalChampion? RoyalChampion { get; set; }
    }

    public class Heroes
    {
        [JsonProperty("Barbarian King")]
        public int? BarbarianKing { get; set; }

        [JsonProperty("Archer Queen")]
        public int? ArcherQueen { get; set; }

        [JsonProperty("Grand Warden")]
        public int? GrandWarden { get; set; }

        [JsonProperty("Royal Champion")]
        public int? RoyalChampion { get; set; }

        [JsonProperty("Minion Prince")]
        public int? MinionPrince { get; set; }
    }

    public class HeroHall
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class HiddenTesla
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class HogPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class InfernoTower
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class InvisibilityVial
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Laboratory
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class LavaloonPuppet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class LifeGem
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class MagicMirror
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class MetalPant
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class MinionPrince
    {
        [JsonProperty("Henchmen Puppet")]
        public List<HenchmenPuppet>? HenchmenPuppet { get; set; }

        [JsonProperty("Dark Orb")]
        public List<DarkOrb>? DarkOrb { get; set; }

        [JsonProperty("Metal Pants")]
        public List<MetalPant>? MetalPants { get; set; }
    }

    public class Mortar
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Mortar2
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class PetHouse
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class RageGem
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class RageVial
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Resource
    {
        [JsonProperty("Gold Storage")]
        public List<GoldStorage>? GoldStorage { get; set; }

        [JsonProperty("Elixir Storage")]
        public List<ElixirStorage>? ElixirStorage { get; set; }

        [JsonProperty("Dark Elixir Storage")]
        public List<DarkElixirStorage>? DarkElixirStorage { get; set; }

        [JsonProperty("Elixir Collector")]
        public List<ElixirCollector>? ElixirCollector { get; set; }

        [JsonProperty("Dark Elixir Collector")]
        public List<DarkElixirCollector>? DarkElixirCollector { get; set; }

        [JsonProperty("Gold Mine")]
        public List<GoldMine>? GoldMine { get; set; }
    }

    public class RocketSpear
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Root
    {
        public Buildings? Buildings { get; set; }
        public Heroes? Heroes { get; set; }

        [JsonProperty("Hero Equipment")]
        public HeroEquipment? HeroEquipment { get; set; }
        public Troops? Troops { get; set; }
        public Spells? Spells { get; set; }

        [JsonProperty("Siege Machines")]
        public SiegeMachines? SiegeMachines { get; set; }
    }

    public class RoyalChampion
    {
        [JsonProperty("Seeking Shield")]
        public List<SeekingShield>? SeekingShield { get; set; }

        [JsonProperty("Royal Gem")]
        public List<RoyalGem>? RoyalGem { get; set; }

        [JsonProperty("Hog Puppet")]
        public List<HogPuppet>? HogPuppet { get; set; }

        [JsonProperty("Haste Vial")]
        public List<HasteVial>? HasteVial { get; set; }

        [JsonProperty("Electro Boots")]
        public List<ElectroBoot>? ElectroBoots { get; set; }

        [JsonProperty("Rocket Spear")]
        public List<RocketSpear>? RocketSpear { get; set; }
    }

    public class RoyalGem
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Scattershot
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class SeekingAirMine
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class SeekingShield
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class SiegeMachines
    {
        [JsonProperty("Wall Wrecker")]
        public int? WallWrecker { get; set; }

        [JsonProperty("Stone Slammer")]
        public int? StoneSlammer { get; set; }

        [JsonProperty("Log Launcher")]
        public int? LogLauncher { get; set; }

        [JsonProperty("Battle Blimp")]
        public int? BattleBlimp { get; set; }

        [JsonProperty("Siege Barracks")]
        public int? SiegeBarracks { get; set; }

        [JsonProperty("Flame Flinger")]
        public int? FlameFlinger { get; set; }

        [JsonProperty("Battle Drill")]
        public int? BattleDrill { get; set; }

        [JsonProperty("Troop Launcher")]
        public int? TroopLauncher { get; set; }
    }

    public class SkeletonTrap
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class SnakeBracelet
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class SpellFactory
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Spells
    {
        [JsonProperty("Elixir Spells")]
        public ElixirSpells? ElixirSpells { get; set; }

        [JsonProperty("Dark Elixir Spells")]
        public DarkElixirSpells? DarkElixirSpells { get; set; }
    }

    public class SpikeyBall
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class SpringTrap
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Support
    {
        [JsonProperty("Helper Hut")]
        public List<HelperHut>? HelperHut { get; set; }

        [JsonProperty("Bob Control")]
        public int? BobControl { get; set; }
        public List<Wall>? Walls { get; set; }
    }

    public class TornadoTrap
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Traps
    {
        [JsonProperty("Air Bombs")]
        public List<AirBomb>? AirBombs { get; set; }
        public List<Bomb>? Bombs { get; set; }

        [JsonProperty("Seeking Air Mines")]
        public List<SeekingAirMine>? SeekingAirMines { get; set; }

        [JsonProperty("Giant Bombs")]
        public List<GiantBomb>? GiantBombs { get; set; }

        [JsonProperty("Spring Traps")]
        public List<SpringTrap>? SpringTraps { get; set; }

        [JsonProperty("Hidden Tesla")]
        public List<HiddenTesla>? HiddenTesla { get; set; }

        [JsonProperty("Tornado Trap")]
        public List<TornadoTrap>? TornadoTrap { get; set; }

        [JsonProperty("Skeleton Trap")]
        public List<SkeletonTrap>? SkeletonTrap { get; set; }
    }

    public class Troops
    {
        [JsonProperty("Elixir Troops")]
        public ElixirTroops? ElixirTroops { get; set; }

        [JsonProperty("Dark Elixir Troops")]
        public DarkElixirTroops? DarkElixirTroops { get; set; }
    }

    public class VampireStache
    {
        public string? Rarity { get; set; }
        public int? Level { get; set; }
    }

    public class Wall
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class WizardTower
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class Workshop
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }

    public class XBow
    {
        public int? level { get; set; }
        public int? count { get; set; }
    }
}
