using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account
{
	public class Account : Endpoint<Data>
	{
		public Data data { get; }
		public Account(string apiKey) : base()
		{
			data = new Data();
			Init("account", data, apiKey);
			Download();
		}
	}

	public class Data {
		internal Data() {}
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
	}
}
