﻿using KHSave.Types;
using System.Collections.Generic;

namespace KHSave.Presets
{
	public static class StoryPresets
	{
		public static Dictionary<int, Dictionary<int, string>> KnownStoryFlags { get; } = new Dictionary<int, Dictionary<int, string>>
		{
			[(int)StoryFlagType.ScalaAdCaelum] = new Dictionary<int, string>
			{
				[0] = "A Strange World",
				[100] = "Before Mysterious Adversaries",
				[200] = "Mysterious Adversaries",
				[218] = "Stairway to the Sky (Before Armored Xehanort)",
				[222] = "Confront Armored Xehanort once you are duly prepared!",
				[244] = "No Information Box",
			},
            [(int)StoryFlagType.SanFransokyo] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.Caribbean] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.DestinyIsland] = new Dictionary<int, string>
			{
				[0] = "Interval VIII: The Destiny Islands",
				[10] = "Return to Light",
				[100] = "A Replica's Resolve Pt. 1",
				[200] = "A Replica's Resolve Pt. 2",
				[9999] = "Story Done",
			},
			[(int)StoryFlagType.LandOfDeparture] = new Dictionary<int, string>
			{
				[0] = "Castle Oblivion Is Unlocked (Part 1)",
				[50] = "Castle Oblivion Is Unlocked (Part 2)",
				[100] = "Before Vanitas fight",
				[200] = "During Vanitas fight",
				[300] = "An End to Slumber (Part 1) (After Vanitas)",
				[490] = "An End to Slumber (Part 2)",
				[502] = "An End to Slumber (Part 3)",
			},
            [(int)StoryFlagType.DarkWorld] = new Dictionary<int, string>
            {
                [0] = "A Dwindling Trail",
                [14] = "The Dark Margin",
                [22] = "Demon Tower I",
                [50] = "Reunion (After Demon Tower I)",
                [100] = "An Unexpected Encounter",
                [200] = "Riku and the King's Peril",
                [300] = "Too Late",
                [410] = "Demon Tower II",
                [520] = "Braving the Darkness",
                [608] = "Anti-Aqua",
                [718] = "Return to the Light (Part 1)",
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.TheFinalWorld] = new Dictionary<int, string>
            {
                [2300] = "End of tutorial",
            },
            [(int)StoryFlagType.Arendelle] = new Dictionary<int, string>
            {
                [3300] = "After exiting Ice Tower",
                [8820] = "Story Done",
            },
            [(int)StoryFlagType.ArendelleAvalanche] = new Dictionary<int, string>
            {
                [0] = "Avalanche Minigame",
                [2120] = "Avalanche Done [Black screen]",
            },
            [(int)StoryFlagType.Gummi] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.Hercules] = new Dictionary<int, string>
            {
                [0] = "Start of Olympus",
                [50] = "After Agora heartless",
                [1280] = "Start of Realm of Gods",
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.KeybladeGraveyard] = new Dictionary<int, string>
			{
				[0] = "Vexen's Return",
				[10] = "The Organization's Origins",
				[50] = "The Xehanorts Gather",
				[100] = "1 Million Heartless",
				[200] = "Before The Final World",
				[11500] = "Start of The Skein of Severance",
				[11600] = "Before 1st Set of Organization XIII Fights",
				[13050] = "Before 2nd Set of Organization XIII Fights",
				[13500] = "Before Young Master Xehanort, Ansem, & Xemnas",
				[14000] = "Xehanort Trio (Black Screen)",
				[14696] = "After Xehanort Trio",
				[99999] = "Story Done",
			},
            [(int)StoryFlagType.Monstropolis] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.Pooh] = new Dictionary<int, string>
            {
                [100] = "First minigame beaten",
                [200] = "Second minigame beaten",
            },
            [(int)StoryFlagType.KingdomOfCorona] = new Dictionary<int, string>
            {
                [3170] = "Going back to Rapunzel's Tower",
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.RadiantGarden] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.SecretForest] = new Dictionary<int, string>
            {
                [0] = "Talking On Paper",
                [10] = "Nothing's As It Should Be",
                [9999] = "Story Done"
            },
            [(int)StoryFlagType.ToyBox] = new Dictionary<int, string>
            {
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.TwilightTown] = new Dictionary<int, string>
            {
                [0] = "Nostalgic Streets",
                [100] = "The Neighborhood Nobodies",
                [116] = "Hello, Good-bye",
                [124] = "Demon Tide I",
                [132] = "Defeat the Demon Tide!",
                [140] = "Before The Woods Powerwilds",
                [200] = "The Woods Powerwilds",
                [250] = "Before Entering the Mansion",
                [300] = "Datascapes (Part 2)",
                [350] = "Before The Old Mansion Fight",
                [400] = "After The Old Mansion Fight",
                [450] = "The Old Mansion Fight",
                [500] = "Collect Ingredients",
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.WorldMap] = new Dictionary<int, string>
            {
                [0] = "Prelude to Adventure (Part 2)",
                [22] = "Heart Within a Heart",
                [100] = "A Replica for Roxas (Part 1)",
                [210] = "A Replica for Roxas (Part 2)",
                [320] = "A Message from Merlin",
                [500] = "A Guiding Key (Part 1)",
                [3000] = "Ienzo Checks In",
                [9999] = "Story Done",
            },
            [(int)StoryFlagType.MysteriousTower] = new Dictionary<int, string>
			{
				[0] = "Prelude to Adventure",
				[10] = "A Fresh Start",
				[100] = "A Quick Review",
				[200] = "The Guardians of Light Gather",
				[300] = "Beneath the Same Stars",
				[9999] = "Story Done",
			},
		};
	}
}