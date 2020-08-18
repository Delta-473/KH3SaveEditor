﻿using KHSave.Attributes;

// thank you HOLLOW_DRAGONITE for this list of ID's you made my life a lot easier

namespace KHSave.LibDDD.Types
{
    public enum EquipmentType : short
    {
        // xx00 - Command Deck Action (not Combat) Commands
        [Info("Jump")] Jump = 0x0100,
        [Info("High Jump")] HighJump = 0x0200,
        [Info("Dodge Roll")] DodgeRoll = 0x0300,
        [Info("Shield Roll")] ShieldRoll = 0x0400,
        [Info("Dark Roll")] DarkRoll = 0x0500,
        [Info("Air Slide")] AirSlide = 0x0600,
        [Info("Sonic Impact")] SonicImpact = 0x0700,
        [Info("Double Impact")] DoubleImpact = 0x0800,
        [Info("Glide")] Glide = 0x0900,
        
        // xx01 - Abilities
        [Ability("Confusion Block")] ConfusionBlock = 0x0001,
        [Ability("Bind Block")] BindBlock = 0x0101,
        [Ability("Poision Block")] PoisonBlock = 0x0201,
        [Ability("Slow Block")] SlowBlock = 0x0301,
        [Ability("Sleep Block")] SleepBlock = 0x0401,
        [Ability("Stop Block")] StopBlock = 0x0501,
        [Ability("Reload Boost")] ReloadBoost = 0x0601,
        [Ability("Defender")] Defender = 0x0701,
        [Ability("Combo Plus")] ComboPlus = 0x0801,
        [Ability("Air Combo Plus")] AirComboPlus = 0x0901,
        [Ability("Combo Master")] ComboMaster = 0x0A01,
        [Ability("Exp Boost")] ExpBoost = 0x0B01,
        [Ability("Exp Walker")] ExpWalker = 0x0C01,
        [Ability("Exp Zero")] ExpZero = 0x0D01,
        [Ability("Damage Syphon")] DamageSyphon = 0x0E01,
        [Ability("Second Chance")] SecondChance = 0x0F01,
        [Ability("Once More")] OnceMore = 0x1001,
        [Ability("Scan")] Scan = 0x1101,
        [Ability("Leaf Bracer")] LeafBracer = 0x1201,
        [Ability("Treasure Magnet")] TreasureMagnet = 0x1301,
        //start assumption
        [Ability("Link Critical")] LinkCritical = 0x1401,
        [Ability("Support Boost")] SupportBoost = 0x1501,
        [Ability("Walking Dream")] WalkingDream = 0x1601,
        
        // xx02 - keyblades
        [Keyblade("Kingdom Key")] KingdomKey = 0x0002,
        [Keyblade("Skull Noise (Sora)")] SkullNoiseS = 0x0102,
        [Keyblade("Guardian Bell (Sora)")] GuardianBellS = 0x0202,
        [Keyblade("Ferris Gear")] FerrisGear = 0x0302,
        [Keyblade("Dual Disc (Sora)")] DualDiscS = 0x0402,
        [Keyblade("All for One (Sora)")] AllForOneS = 0x0502,
        [Keyblade("Counterpoint (Sora)")] CounterpointS = 0x0602,
        [Keyblade("Sweet Dreams (Sora)")] SweetDreamsS = 0x0702,
        [Keyblade("Ultima Weapon (Sora)")] UltimaWeaponS = 0x0802,
        [Keyblade("Unbound (Sora)")] UnboundS = 0x0902,
        [Keyblade("Dive Wing (Sora)")] DiveWingS = 0x0A02,
        [Keyblade("End of Pain (Sora)")] EndOfPainS = 0x0B02,
        [Keyblade("Knockout Punch (Sora)")] KnockoutPunchS = 0x0c02,
        [Keyblade("UNNAMED (Description: RS-READY LARGE KEYBLADE ROSE HELP)")] UnnamedK1 = 0x0d02,
        [Keyblade("UNNAMED (Description: RS-READY LARGE KEYBLADE ASSEMBLY HELP)")] UnnamedK2 = 0x0e02,
        [Keyblade("SORA UNUSED KBLADE (Description: SORA UNUSED KEYBLADE 3 HELP)")] UnusedK1 = 0x0f02,
        [Keyblade("Soul Eater")] SoulEater = 0x1002,
        [Keyblade("Skull Noise (Riku)")] SkullNoiseR = 0x1102,
        [Keyblade("Guardian Bell (Riku)")] GuardianBellR = 0x1202,
        [Keyblade("Ocean's Rage")] OceansRage = 0x1302,
        //start assumption based on patern
        [Keyblade("Dual Disc (Riku)")] DualDiscR = 0x1402,
        [Keyblade("All for One (Riku)")] AllForOneR = 0x1502,
        [Keyblade("Counterpoint (Riku)")] CounterpointR = 0x1602,
        [Keyblade("Sweet Dreams (Riku)")] SweetDreamsR = 0x1702,
        [Keyblade("Ultima Weapon (Riku)")] UltimaWeaponR = 0x1802,
        [Keyblade("Unbound (Riku)")] UnboundR = 0x1902,
        [Keyblade("Dive Wing (Riku)")] DiveWingR = 0x1a02,
        [Keyblade("End of Pain (Riku)")] EndOfPainR = 0x1b02,
        [Keyblade("Knockout Punch (Riku)")] KnockoutPunchR = 0x1c02,
        [Unused] Unused1D02 = 0x1d02,
        // end assumption
        [Keyblade("Way to the Dawn")] WayToTheDawn = 0x1F02,

        // xx03 - Recipes
        [Recipe("Meow Wow Recipe")] MeowWowRecipe = 0x0003,
        [Recipe("Tama Sheep Recipe")] TamaSheepRecipe = 0x0103,
        [Recipe("Yoggy Ram Recipe")] YoggyRamRecipe = 0x0203,
        [Recipe("Komoroy Bat Recipe")] KomoroyBatRecipe = 0x0303,
        [Recipe("Pricklemane Recipe")] PricklemaneRecipe = 0x0403,
        [Recipe("Hebby Repp Recipe")] HebbyReppRecipe = 0x0503,
        [Recipe("Sir Kyroo Recipe")] SirKyrooRecipe = 0x0603,
        [Recipe("Toximander Recipe")] ToximanderRecipe = 0x0703,
        [Recipe("Fin Fatale Recipe")] FinFataleRecipe = 0x0803,
        [Recipe("Tatsu Steed Recipe")] TatsuSteedRecipe = 0x0903,
        [Recipe("Necho Cat Recipe")] NechoCatRecipe = 0x0A03,
        [Recipe("Thunderaffe Recipe")] ThunderaffeRecipe = 0x0B03,
        [Recipe("Kooma Panda Recipe")] KoomaPandaRecipe = 0x0C03,
        [Recipe("Pegaslick Recipe")] PegaslickRecipe = 0x0D03,
        [Recipe("Iceguin Ace Recipe")] IceguinAceRecipe = 0x0E03,
        [Recipe("Peepsta Hoo Recipe")] PeepstaHooRecipe = 0x0F03,
        [Recipe("Escarglow Recipe")] EscarglowRecipe = 0x1003,
        [Recipe("K.O. Kabuto Recipe")] KOKabutoRecipe = 0x1103,
        [Recipe("Wheeflower Recipe")] WheeflowerRecipe = 0x1203,
        [Recipe("Ghostabocky Recipe")] GhostabockyRecipe = 0x1303,
        // start assumption
        [Recipe("Zolephant Recipe")] ZolephantRecipe = 0x1403,
        [Recipe("Juggle Pup Recipe")] JugglePupRecipe = 0x1503,
        [Recipe("Halbird Recipe")] HalbirdRecipe = 0x1603,
        [Recipe("Staggerceps Recipe")] StaggercepsRecipe = 0x1703,
        [Recipe("Fishboné Recipe")] FishboneRecipe = 0x1803,
        [Recipe("Flowbermeow Recipe")] FlowbermeowRecipe = 0x1903,
        [Recipe("Cyber Yog Recipe")] CyberYogRecipe = 0x1A03,
        [Recipe("Chef Kyroo Recipe")] ChefKyrooRecipe = 0x1B03,
        [Recipe("Lord Kyroo Recipe")] LordKyrooRecipe = 0x1C03,
        [Recipe("Tatsu Blaze Recipe")] TatsuBlazeRecipe = 0x1D03,
        [Recipe("Electricorn Recipe")] ElectricornRecipe = 0x1E03,
        [Recipe("Woeflower Recipe")] WoeflowerRecipe = 0x1F03,
        [Recipe("Jestabocky Recipe")] JestabockyRecipe = 0x2003,
        [Recipe("Eaglider Recipe")] EagliderRecipe = 0x2103,
        [Recipe("Me Me Bunny Recipe")] MeMeBunnyRecipe = 0x2203,
        [Recipe("Drill Sye Recipe")] DrillSyeRecipe = 0x2303,
        [Recipe("Tyranto Rex Recipe")] TyrantoRexRecipe = 0x2403,
        [Recipe("Majik Lapin Recipe")] MajikLapinRecipe = 0x2503,
        [Recipe("Cera Terror Recipe")] CeraTerrorRecipe = 0x2603,
        [Recipe("Skelterwild Recipe")] SkelterwildRecipe = 0x2703,
        [Recipe("Ducky Goose Recipe")] DuckyGooseRecipe = 0x2803,
        [Recipe("Aura Lion Recipe")] AuraLionRecipe = 0x2903,
        [Recipe("Ryu Dragon Recipe")] RyuDragonRecipe = 0x2A03,
        [Recipe("Drak Quack Recipe")] DrakQuackRecipe = 0x2B03,
        [Recipe("Keeba Tiger Recipe")] KeebaTigerRecipe = 0x2C03,
        [Recipe("Meowjesty Recipe")] MeowjestyRecipe = 0x2D03,
        [Recipe("Sudo Neku Recipe")] SudoNekuRecipe = 0x2E03,
        [Recipe("Ursa Circus Recipe")] UrsaCircusRecipe = 0x2F03,

        // xx04 - Key Items
        [KeyItem("Stage Gadget")] StageGadget = 0x0004,
        [KeyItem("KEY ITEM 2 (Jikuu Shard 2 Help)")] KeyItem2 = 0x0104,
        [KeyItem("KEY ITEM 3 (Jikuu Shard 3 Help)")] KeyItem3 = 0x0204,
        [KeyItem("KEY ITEM 4")] KeyItem4 = 0x0304,

        // xx05 - Glosary

        // xx06 - Dream Pieces

        // xx07 - Training Toys (Food)

        // xx08 - Training Toys (Toys)

        // xx09 - Memento Entries
    }
}
