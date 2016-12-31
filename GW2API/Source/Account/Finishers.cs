using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Finishers
{
	public class Finishers : Endpoint<List<Finisher>>
	{
		public List<Finisher> data { get; }

		public Finishers(string apiKey)
		{
			data = new List<Finisher>();
			Init("account/finishers", data, apiKey);
		}
	}
		
	public class Finisher
	{
		internal Finisher() {}
		public int id { get; set; }
		public bool permanent { get; set; }
		public int? quantity { get; set; }
	}
}
	