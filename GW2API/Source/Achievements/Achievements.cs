using GW2API.Core;
using System;
using System.Collections.Generic;

namespace GW2API.Achievements
{
	public class Achievements : Endpoint<List<Achievement>>
	{
		public List<Achievement> data { get; }
		public Achievements(List<int> ids) : base()
		{
			data = new List<Achievement>();
			Init("achievements", data);
			Download(ids);
		}

		public void Download(List<int> ids)
		{
			List<Tuple<string, string>> parameters = new List<Tuple<string, string>>();
			parameters.Add(new Tuple<string, string>("ids", string.Join(",", ids)));
			base.Download();
		}
	}
		
	public class Tier
	{
		public int count { get; set; }
		public int points { get; set; }
	}

	public class Reward
	{
		public string type { get; set; }
		public int id { get; set; }
		public int count { get; set; }
		public string region { get; set; }
	}

	public class Bit
	{
		public string type { get; set; }
		public int id { get; set; }
		public string text { get; set; }
	}

	public class Achievement
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public string requirement { get; set; }
		public string locked_text { get; set; }
		public string type { get; set; }
		public List<string> flags { get; set; }
		public List<Tier> tiers { get; set; }
		public List<Reward> rewards { get; set; }
		public List<Bit> bits { get; set; }
	}

}
