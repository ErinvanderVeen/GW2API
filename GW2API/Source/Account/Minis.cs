using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Minis
{
	public class Minis : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Minis(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/minis", data, apiKey);
			Download();
		}
	}
}
