using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Outfits
{
	public class Outfits : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Outfits(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/outfits", data, apiKey);
		}
	}
}
