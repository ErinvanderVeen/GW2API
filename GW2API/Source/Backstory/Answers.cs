using GW2API.Core;
using System.Collections.Generic;

namespace GW2API.Backstory.Answers
{
	public class Answers : Endpoint<List<string>>
	{
		public Data data { get; }
		public Answers(string apiKey) : base()
		{
			data = new List<string>();
			Init("backstory/answers", data, apiKey);
			Download();
		}
	}
}
