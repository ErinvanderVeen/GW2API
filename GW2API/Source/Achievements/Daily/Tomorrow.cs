using GW2API.Core;
using GW2API.Core.DailyAchievements;
using System.Collections.Generic;

namespace GW2API.Achievements.Daily.Tomorrow
{
	public class Daily : Endpoint<DailyAchievements>
	{
		public DailyAchievements data { get; }
		public Daily() : base()
		{
			data = new DailyAchievements();
			Init("achievements/daily/tomorrow", data);
			Download();
		}
	}
}
