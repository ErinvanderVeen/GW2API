using GW2API.Core;
using GW2API.Core.CraftingMaterial;
using System.Collections.Generic;

namespace GW2API.Account.Materials
{
	public class Materials : Endpoint<List<CraftingMaterial>>
	{
		public List<CraftingMaterial> data { get; }

		public Materials(string apiKey) : base()
		{
			data = new List<CraftingMaterial>();
			Init("account/materials", data, apiKey);
			Download();
		}
	}
}
