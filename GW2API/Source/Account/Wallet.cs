using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Account.Wallet
{
	public class Wallet : Endpoint<List<Currency>>
	{
		public List<Currency> data { get; }

		public Wallet(string apiKey) : base()
		{
			data = new List<Currency>();
			Init("account/wallet", data, apiKey);
			Download();
		}
	}
		
	public class Currency
	{
		public int id { get; set; }
		public int value { get; set; }
	}

}
