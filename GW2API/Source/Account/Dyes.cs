using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Dyes
{
	public class Dyes : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Dyes(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/dyes", data, apiKey);
			Download();
		}
	}
}
