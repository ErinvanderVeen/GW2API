using GW2API.Core;
using GW2API.Core.ItemSlot;
using System.Collections.Generic;

namespace GW2API.Account.Inventory
{
	public class Inventory : Endpoint<List<ItemSlot>>
	{
		public List<ItemSlot> data { get; }

		public Inventory(string apiKey)
		{
			data = new List<ItemSlot>();
			Init("account/inventory", data, apiKey);
		}
	}
}
