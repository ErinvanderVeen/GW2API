using GW2API.Core;
using GW2API.Core.DailyAchievements;
using System.Collections.Generic;

namespace GW2API.Achievements.Daily
{
	public class Daily : Endpoint<DailyAchievements>
	{
		public DailyAchievements data { get; }
		public Daily() : base()
		{
			data = new DailyAchievements();
			Init("achievements/daily", data);
			Download();
		}
	}
}
