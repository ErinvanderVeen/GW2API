using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace GW2API.Core
{
	internal class GW2API<T>
	{
		private string apiKey;
		private string endpoint;
		private const string baseURL = "https://api.guildwars2.com/v2/";
		private T target;

		internal GW2API (T target, string endpoint, string apiKey = null)
		{
			this.target = target;
			this.endpoint = endpoint;
			this.apiKey = apiKey;
		}

		internal void Download (List<Tuple<string, string>> parameters = null)
		{
			string url = CreateURL (target, parameters);
			string json;

			using (WebClient wc = new WebClient ())
			{
				wc.Headers.Add (HttpRequestHeader.Authorization, "Bearer " + apiKey);
				json = wc.DownloadString(url);
			}

			JsonConvert.PopulateObject (json, target);
		}

		private string CreateURL (T target, List<Tuple<string, string>> parameters = null)
		{
			string fullURL = baseURL + endpoint + "?";

			if (parameters != null) {
				fullURL += parametersToString (parameters);
			}

			return fullURL;
		}

		private string parametersToString (List<Tuple<string, string>> parameters)
		{
			string result = "";
			foreach (Tuple<string, string> param in parameters) {
				result += param.Item1 + "=" + param.Item2 + "&";
			}
			return result;
		}
	}
}
