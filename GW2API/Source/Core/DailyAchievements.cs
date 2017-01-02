using System;
using System.Collections.Generic;

namespace GW2API.Core.DailyAchievements
{
	public class Level
	{
		public int min { get; set; }
		public int max { get; set; }
	}

	public class Pve
	{
		public int id { get; set; }
		public Level level { get; set; }
		public List<string> required_access { get; set; }
	}

	public class Pvp
	{
		public int id { get; set; }
		public Level level { get; set; }
		public List<string> required_access { get; set; }
	}

	public class Wvw
	{
		public int id { get; set; }
		public Level level { get; set; }
		public List<string> required_access { get; set; }
	}

	public class Special
	{
		public int id { get; set; }
		public Level level { get; set; }
		public List<string> required_access { get; set; }
	}

	public class DailyAchievements
	{
		public List<Pve> pve { get; set; }
		public List<Pvp> pvp { get; set; }
		public List<Wvw> wvw { get; set; }
		public List<Special> special { get; set; }
	}
}
