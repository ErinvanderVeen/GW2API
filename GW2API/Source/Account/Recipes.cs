using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Recipes
{
	public class Recipes : Endpoint<List<int>>
	{
		public List<int> data { get; }

		public Recipes(string apiKey) : base()
		{
			data = new List<int>();
			Init("account/recipes", data, apiKey);
		}
	}
}
