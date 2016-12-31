using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Skins
{
	public class Skins : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Skins(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/skins", data, apiKey);
		}
	}
}
