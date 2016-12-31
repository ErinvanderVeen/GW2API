using GW2API.Core;
using GW2API.Core.ItemSlot;
using System.Collections.Generic;

namespace GW2API.Account.Bank
{
	public class Bank : Endpoint<List<ItemSlot>>
	{
		public List<ItemSlot> data { get; }

		public Bank(string apiKey) : base()
		{
			data = new List<ItemSlot>();
			Init("account/bank", data, apiKey);
		}
	}
}
