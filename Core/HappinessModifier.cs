using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace BetterHappiness.Core
{
	public abstract class HappinessModifier : ModType
	{
		protected sealed override void Register()
		{
			ModTypeLookup<HappinessModifier>.Register(this);

			HappinessModifierLoader.HappinessMods.Add(this);
		}

		/// <summary>
		/// Allows you to make a happiness modifier only take effect for certain NPCs.<br/>
		/// By default, returns true for all NPCs.
		/// </summary>
		/// <param name="npc">The NPC to check against this happiness modifier working on.</param>
		/// <returns></returns>
		public virtual bool AppliesToNPC(NPC npc) => true;

		/// <summary>
		/// Used to define how much this happiness modifier should affect the NPC's happiness.<br/>
		/// <b>Mandatory.</b>
		/// </summary>
		/// <param name="npc">The NPC whose happiness is being adjusted.</param>
		/// <returns>The amount of happiness which this modifier should add to or remove from the total, represented as a decimal.</returns>
		public abstract double AdjustHappiness(NPC npc);
	}
}
