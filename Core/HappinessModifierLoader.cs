using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace BetterHappiness.Core
{
	public static class HappinessModifierLoader
	{
		internal static List<HappinessModifier> HappinessMods = [];

		internal static void Load()
		{
			HappinessMods = [
			];
		}

		internal static void Unload()
		{
			HappinessMods = null;
		}

		public static void AdjustHappiness(NPC npc, ref double happiness)
		{
			foreach (HappinessModifier happyMod in HappinessMods)
			{
				happiness += happyMod.AdjustHappiness(npc);
			}
		}
	}
}
