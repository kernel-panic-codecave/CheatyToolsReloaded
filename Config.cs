using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace CheatyToolsReloaded
{
    [Label("Tools")]
    [SeparatePage]
    public class SuperCheatyConfigTools : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Pick Pickaxe Power")]
        public int PickPickaxePower;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Drill Pickaxe Power")]
        public int DrillPickaxePower;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Chainsaw Axe Power")]
        public int ChainsawAxePower;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Hamaxe Axe Power")]
        public int HamaxeAxePower;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Hamaxe Hammer Power")]
        public int HamaxeHammerPower;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Jackhammer Hammer Power")]
        public int JackhammerHammerPower;
    }
    [Label("Weapons")]
    [SeparatePage]
    public class SuperCheatyConfigWeapons : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Sword Attack Damage")]
        public int SwordDamage;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Yoyo Attack Damage")]
        public int YoyoDamage;
    }
    [Label("Armor")]
    [SeparatePage]
    public class SuperCheatyConfigArmor : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Label("Super Cheaty Tank Armor Defense")]
        [Tooltip("Helmet\nBreastplate\nLeggings")]
        [Range(0, 100000000)]
        public int[] TankDefense = new int[] { 100000000, 100000000, 100000000 };
        [DefaultValue(4)]
        [Label("Super Cheaty Tank Armor Health Multiplier")]
        [Range(0, 100000000)]
        public int TankHealthMultiplier;
        [Label("Super Cheaty Mage Armor Defense")]
        [Tooltip("Helmet\nBreastplate\nLeggings")]
        [Range(0, 100000000)]
        public int[] MageDefense = new int[] { 100000000, 100000000, 100000000 };
        [DefaultValue(4)]
        [Label("Super Cheaty Mage Armor Mana Multiplier")]
        [Range(0, 100000000)]
        public int MageManaMultiplier;
        [Label("Super Cheaty Ranged Armor Defense")]
        [Tooltip("Helmet\nBreastplate\nLeggings")]
        [Range(0, 100000000)]
        public int[] RangedDefense = new int[] { 100000000, 100000000, 100000000 };
        [DefaultValue(100000000)]
        [Label("Super Cheaty Ranged Armor Damage Multiplier")]
        [Range(0, 100000000)]
        public int RangedDamageMultiplier;
        [Label("Super Cheaty Summoner Armor Defense")]
        [Tooltip("Helmet\nBreastplate\nLeggings")]
        [Range(0, 100000000)]
        public int[] SummonerDefense = new int[] { 100000000, 100000000, 100000000 };
        [DefaultValue(100000000)]
        [Label("Super Cheaty Summoner Armor Minion Slot Multiplier")]
        [Range(0, 100000000)]
        public int SummonerMinionMultiplier;
    }
    [Label("Accessories")]
    [SeparatePage]
    public class SuperCheatyConfigAccessories : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [DefaultValue(100000000)]
        [Label("Super Cheaty Wings Flight Duration")]
        public int WingFlightTime;
    }
}