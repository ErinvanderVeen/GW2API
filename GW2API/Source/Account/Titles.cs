using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Titles
{
	public class Titles : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Titles(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/titles", data, apiKey);
			Download();
		}
	}
}
