using Newtonsoft.Json;

namespace clashProgress.upgrade_times_data
{
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AirBombs
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class AirDefense
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class AirSweeper
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class ApprenticeWarden
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Archer
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class ArcherQueen
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class ArcherTowers
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class ArmyCamp
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class BabyDragon
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Balloon
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Barbarian
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class BarbarianKing
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Barracks
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Bat
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class BattleBlimp
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class BattleDrill
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Blacksmith
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Bombs
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class BombTower
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Bowler
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class BuilderSHut
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Buildings
    {
        public Cannons Cannons { get; set; }

        [JsonProperty("Archer Towers")]
        public ArcherTowers ArcherTowers { get; set; }

        [JsonProperty("Wizard Towers")]
        public WizardTowers WizardTowers { get; set; }
        public Mortars Mortars { get; set; }

        [JsonProperty("Air Defense")]
        public AirDefense AirDefense { get; set; }

        [JsonProperty("Bomb Tower")]
        public BombTower BombTower { get; set; }

        [JsonProperty("Inferno Towers")]
        public InfernoTowers InfernoTowers { get; set; }

        [JsonProperty("X-Bows")]
        public XBows XBows { get; set; }

        [JsonProperty("Builder's Hut")]
        public BuilderSHut BuildersHut { get; set; }
        public Scattershot Scattershot { get; set; }

        [JsonProperty("Eagle Artillery")]
        public EagleArtillery EagleArtillery { get; set; }
        public Mortar Mortar { get; set; }

        [JsonProperty("Air Sweeper")]
        public AirSweeper AirSweeper { get; set; }
        public Barracks Barracks { get; set; }

        [JsonProperty("Dark Barracks")]
        public DarkBarracks DarkBarracks { get; set; }

        [JsonProperty("Spell Factory")]
        public SpellFactory SpellFactory { get; set; }

        [JsonProperty("Dark Spell Factory")]
        public DarkSpellFactory DarkSpellFactory { get; set; }
        public Workshop Workshop { get; set; }
        public Laboratory Laboratory { get; set; }

        [JsonProperty("Army Camp")]
        public ArmyCamp ArmyCamp { get; set; }

        [JsonProperty("Hero Hall")]
        public HeroHall HeroHall { get; set; }

        [JsonProperty("Pet House")]
        public PetHouse PetHouse { get; set; }
        public Blacksmith Blacksmith { get; set; }

        [JsonProperty("Clan Castle")]
        public ClanCastle ClanCastle { get; set; }

        [JsonProperty("Gold Storage")]
        public GoldStorage GoldStorage { get; set; }

        [JsonProperty("Elixir Storage")]
        public ElixirStorage ElixirStorage { get; set; }

        [JsonProperty("Dark Elixir Storage")]
        public DarkElixirStorage DarkElixirStorage { get; set; }

        [JsonProperty("Elixir Collector")]
        public ElixirCollector ElixirCollector { get; set; }

        [JsonProperty("Dark Elixir Collector")]
        public DarkElixirCollector DarkElixirCollector { get; set; }

        [JsonProperty("Gold Mine")]
        public GoldMine GoldMine { get; set; }

        [JsonProperty("Air Bombs")]
        public AirBombs AirBombs { get; set; }
        public Bombs Bombs { get; set; }

        [JsonProperty("Seeking Air Mines")]
        public SeekingAirMines SeekingAirMines { get; set; }

        [JsonProperty("Giant Bombs")]
        public GiantBombs GiantBombs { get; set; }

        [JsonProperty("Spring Traps")]
        public SpringTraps SpringTraps { get; set; }

        [JsonProperty("Hidden Tesla")]
        public HiddenTesla HiddenTesla { get; set; }

        [JsonProperty("Tornado Trap")]
        public TornadoTrap TornadoTrap { get; set; }

        [JsonProperty("Skeleton Trap")]
        public SkeletonTrap SkeletonTrap { get; set; }

        [JsonProperty("Helper Hut")]
        public HelperHut HelperHut { get; set; }
    }

    public class Cannons
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("5")]
        public string _5 { get; set; }

        [JsonProperty("6")]
        public string _6 { get; set; }

        [JsonProperty("7")]
        public string _7 { get; set; }

        [JsonProperty("8")]
        public string _8 { get; set; }

        [JsonProperty("9")]
        public string _9 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }

        [JsonProperty("11")]
        public string _11 { get; set; }

        [JsonProperty("12")]
        public string _12 { get; set; }

        [JsonProperty("13")]
        public string _13 { get; set; }

        [JsonProperty("14")]
        public string _14 { get; set; }

        [JsonProperty("15")]
        public string _15 { get; set; }

        [JsonProperty("16")]
        public string _16 { get; set; }

        [JsonProperty("17")]
        public string _17 { get; set; }
    }

    public class ClanCastle
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Clone
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class DarkBarracks
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class DarkElixirCollector
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class DarkElixirStorage
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class DarkSpellFactory
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Dragon
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Druid
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class EagleArtillery
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Earthquake
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class ElectroDragon
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class ElectroTitan
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class ElixirCollector
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class ElixirStorage
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class FlameFlinger
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Freeze
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Giant
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class GiantBombs
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Goblin
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class GoldMine
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class GoldStorage
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Golem
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class GrandWarden
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Haste
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class HeadHunter
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Healer
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Healing
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class HelperHut
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Heroes
    {
        [JsonProperty("Barbarian King")]
        public BarbarianKing BarbarianKing { get; set; }

        [JsonProperty("Archer Queen")]
        public ArcherQueen ArcherQueen { get; set; }

        [JsonProperty("Grand Warden")]
        public GrandWarden GrandWarden { get; set; }

        [JsonProperty("Royal Champion")]
        public RoyalChampion RoyalChampion { get; set; }

        [JsonProperty("Minion Prince")]
        public MinionPrince MinionPrince { get; set; }
    }

    public class HeroHall
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class HiddenTesla
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class HogRider
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class IceGolem
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class InfernoTowers
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Invisibility
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Jump
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Laboratory
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class LavaHound
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Lightning
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class LogLauncher
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Miner
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Minion
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class MinionPrince
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Mortar
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Mortars
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Overgrowth
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class PEKKA
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class PetHouse
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Poison
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Rage
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Recall
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Revive
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Root
    {
        public Buildings Buildings { get; set; }
        public Heroes Heroes { get; set; }
        public Troops Troops { get; set; }
    }

    public class RootRider
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class RoyalChampion
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Scattershot
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class SeekingAirMines
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class SiegeBarracks
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class SiegeMachines
    {
        [JsonProperty("Wall Wrecker")]
        public WallWrecker WallWrecker { get; set; }

        [JsonProperty("Stone Slammer")]
        public StoneSlammer StoneSlammer { get; set; }

        [JsonProperty("Log Launcher")]
        public LogLauncher LogLauncher { get; set; }

        [JsonProperty("Battle Blimp")]
        public BattleBlimp BattleBlimp { get; set; }

        [JsonProperty("Siege Barracks")]
        public SiegeBarracks SiegeBarracks { get; set; }

        [JsonProperty("Flame Flinger")]
        public FlameFlinger FlameFlinger { get; set; }

        [JsonProperty("Battle Drill")]
        public BattleDrill BattleDrill { get; set; }

        [JsonProperty("Troop Launcher")]
        public TroopLauncher TroopLauncher { get; set; }
    }

    public class Skeleton
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class SkeletonTrap
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class SpellFactory
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Spells
    {
        public Lightning Lightning { get; set; }
        public Healing Healing { get; set; }
        public Rage Rage { get; set; }
        public Jump Jump { get; set; }
        public Clone Clone { get; set; }
        public Freeze Freeze { get; set; }
        public Invisibility Invisibility { get; set; }
        public Recall Recall { get; set; }
        public Revive Revive { get; set; }
        public Poison Poison { get; set; }
        public Earthquake Earthquake { get; set; }
        public Haste Haste { get; set; }
        public Skeleton Skeleton { get; set; }
        public Bat Bat { get; set; }
        public Overgrowth Overgrowth { get; set; }
    }

    public class SpringTraps
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class StoneSlammer
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Thrower
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class TornadoTrap
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class TroopLauncher
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Troops
    {
        public Barbarian Barbarian { get; set; }
        public Archer Archer { get; set; }
        public Giant Giant { get; set; }
        public Goblin Goblin { get; set; }

        [JsonProperty("Wall Breaker")]
        public WallBreaker WallBreaker { get; set; }
        public Balloon Balloon { get; set; }
        public Wizard Wizard { get; set; }
        public Healer Healer { get; set; }
        public Dragon Dragon { get; set; }

        [JsonProperty("P.E.K.K.A")]
        public PEKKA PEKKA { get; set; }

        [JsonProperty("Baby Dragon")]
        public BabyDragon BabyDragon { get; set; }
        public Miner Miner { get; set; }

        [JsonProperty("Electro Dragon")]
        public ElectroDragon ElectroDragon { get; set; }
        public Yeti Yeti { get; set; }

        [JsonProperty("Electro Titan")]
        public ElectroTitan ElectroTitan { get; set; }

        [JsonProperty("Root Rider")]
        public RootRider RootRider { get; set; }
        public Thrower Thrower { get; set; }
        public Minion Minion { get; set; }

        [JsonProperty("Hog Rider")]
        public HogRider HogRider { get; set; }
        public Valkyrie Valkyrie { get; set; }
        public Golem Golem { get; set; }
        public Witch Witch { get; set; }

        [JsonProperty("Lava Hound")]
        public LavaHound LavaHound { get; set; }
        public Bowler Bowler { get; set; }

        [JsonProperty("Ice Golem")]
        public IceGolem IceGolem { get; set; }

        [JsonProperty("Head Hunter")]
        public HeadHunter HeadHunter { get; set; }

        [JsonProperty("Apprentice Warden")]
        public ApprenticeWarden ApprenticeWarden { get; set; }
        public Druid Druid { get; set; }
        public Spells Spells { get; set; }

        [JsonProperty("Siege Machines")]
        public SiegeMachines SiegeMachines { get; set; }
    }

    public class Valkyrie
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class WallBreaker
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class WallWrecker
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Witch
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class Wizard
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }

    public class WizardTowers
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Workshop
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class XBows
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }
    }

    public class Yeti
    {
        [JsonProperty("1")]
        public string _1 { get; set; }

        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }
    }


}
