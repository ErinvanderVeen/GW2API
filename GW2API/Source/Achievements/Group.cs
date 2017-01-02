using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Achievements.Group
{
	public class Group : Endpoint<Data>
	{
		public Data data { get; }
		public Group(string group) : base()
		{
			data = new Data();
			Init("achievements/groups/" + group, data);
			Download();
		}
	}

	public class Data
	{
		public string id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public int order { get; set; }
		public List<int> categories { get; set; }
	}
}
