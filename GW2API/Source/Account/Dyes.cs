using System;
using System.Collections.Generic;
using GW2API.Core;

namespace GW2API.Account.Dyes
{
	public class Dyes
	{
		private GW2API<List<int>> gw2api;

		public List<int> dyes { get; set; }

		public Dyes (string apiKey)
		{
			this.dyes = new List<int> ();
			this.gw2api = new GW2API<List<int>> (dyes, "account/dyes", apiKey);
		}

		public void Update ()
		{
			gw2api.Download ();
		}
	}
}
