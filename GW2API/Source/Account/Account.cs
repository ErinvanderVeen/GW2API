using System;
using System.Collections.Generic;
using GW2API.Core;

namespace GW2API.Account
{
	public class Account
	{
		private GW2API<Account> gw2api;

		public string id { get; set; }
		public string name { get; set; }
		public int world { get; set; }
		public List<string> guilds { get; set; }
		public string created { get; set; }
		public string access { get; set; }
		public bool commander { get; set; }
		public int fractal_level { get; set; }
		public int daily_ap { get; set; }
		public int monthly_ap { get; set; }
		public int wvw_rank { get; set; }

		public Account (string apiKey)
		{
			this.gw2api = new GW2API<Account> (this, "account", apiKey);
		}

		public void Update ()
		{
			gw2api.Download ();
		}
	}
}
