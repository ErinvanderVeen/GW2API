using System;
using System.Collections.Generic;
using GW2API.Core;

namespace GW2API.Account.Finishers
{
	public class Finishers
	{
		private GW2API<List<Finisher>> gw2api;

		public List<Finisher> finishers { get; set; }

		public Finishers (string apiKey)
		{
			this.finishers = new List<Finisher> ();
			this.gw2api = new GW2API<List<Finisher>> (finishers, "account/finishers", apiKey);
		}

		public void Update ()
		{
			gw2api.Download ();
		}
	}
		
	public class Finisher
	{
		public int id { get; set; }
		public bool permanent { get; set; }
		public int? quantity { get; set; }
	}
}
	