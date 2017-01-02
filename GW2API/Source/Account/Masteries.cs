using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Masteries
{
	public class Masteries : Endpoint<List<Mastery>>
	{
		public List<Mastery> data { get; }

		public Masteries(string apiKey) : base()
		{
			data = new List<Mastery>();
			Init("account/masteries", data, apiKey);
			Download();
		}
	}
		
	public class Mastery
	{
		public int id { get; set; }
		public int level { get; set; }
	}

}
	