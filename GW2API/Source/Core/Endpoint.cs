using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace GW2API.Core
{
	public class Endpoint<T>
	{
		private string apiKey;
		private string endpoint;
		private T target;
		private const string baseURL = "https://api.guildwars2.com/v2/";

		internal void Init(string endpoint, T target, string apiKey = null)
		{
			this.apiKey = apiKey;
			this.endpoint = endpoint;
			this.target = target;
			Download();
		}

		public void Download(List<Tuple<string, string>> parameters = null)
		{
			string url = CreateURL(target, parameters);
			string json;

			using (WebClient wc = new WebClient())
			{
				if (apiKey != null)
					wc.Headers.Add (HttpRequestHeader.Authorization, "Bearer " + apiKey);
				json = wc.DownloadString(url);
			}

			JsonConvert.PopulateObject(json, target);
		}

		private string CreateURL(T target, List<Tuple<string, string>> parameters)
		{
			string fullURL = baseURL + endpoint;

			fullURL += parameters != null ? "?" + parametersToString(parameters) : "";

			return fullURL;
		}

		private string parametersToString(List<Tuple<string, string>> parameters)
		{
			string result = "";
			foreach (Tuple<string, string> param in parameters) {
				result += param.Item1 + "=" + param.Item2 + "&";
			}
			return result;
		}
	}
}
