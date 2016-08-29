using System;
using System.Collections.Generic;
using GW2API.Core;

namespace GW2API.Account.Achievements
{
	public class Achievements
	{
		private GW2API<List<Achievement>> gw2api;

		public List<Achievement> achievements { get; set; }

		public Achievements (string apiKey)
		{
			this.achievements = new List<Achievement> ();
			this.gw2api = new GW2API<List<Achievement>> (achievements, "account/achievements", apiKey);
		}

		public void Update ()
		{
			gw2api.Download ();
		}
	}

	public class Achievement
	{
		public int id { get; set; }
		public int current { get; set; }
		public int max { get; set; }
		public bool done { get; set; }
		public List<object> bits { get; set; }
		public bool? unlocked { get; set; }
		public int? repeated { get; set; }
	}
}

