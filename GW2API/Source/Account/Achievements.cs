using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Achievements
{
	public class Achievements : Endpoint<List<Achievement>>
	{
		public List<Achievement> data { get; }

		public Achievements(string apiKey) : base()
		{
			data = new List<Achievement>();
			Init("account/achievements", data, apiKey);
		}
	}

	public class Achievement
	{
		internal Achievement() {}
		public int id { get; set; }
		public int current { get; set; }
		public int max { get; set; }
		public bool done { get; set; }
		public List<object> bits { get; set; }
		public bool? unlocked { get; set; }
		public int? repeated { get; set; }
	}
}
