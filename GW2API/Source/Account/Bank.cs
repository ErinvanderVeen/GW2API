using System;
using System.Collections.Generic;
using GW2API.Core;

namespace GW2API.Account.Bank
{
	public class Bank
	{
		private GW2API<List<Item>> gw2api;

		public List<Item> items { get; set; }

		public Bank (string apiKey)
		{
			this.items = new List<Item> ();
			this.gw2api = new GW2API<List<Item>> (items, "account/bank", apiKey);
		}

		public void Update ()
		{
			gw2api.Download ();
		}
	}
}
