using System;
using System.Collections.Generic;
using GW2API.Core;

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
