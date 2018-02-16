using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CreativeGurus.Weather.Wunderground.Utilities
{
	internal static class RestRequest
	{
		internal static T Execute<T>(Uri uri) where T : new()
		{
			return Task.Run(async () => await ExecuteAsync<T>(uri).ConfigureAwait(false)).Result;
		}

		internal static async Task<T> ExecuteAsync<T>(Uri uri) where T : new()
		{
			HttpClient client = new HttpClient();
			var response = await client.GetAsync(uri).ConfigureAwait(false);

			var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			if (content.Contains("keynotfound")) { throw new ArgumentException("Invalid API key"); }

			if (response.IsSuccessStatusCode)
			{
				if (content.Length > 0)
				{
					//return JsonConvert.DeserializeObject<T>(content, new BoolConverter(), new DoubleConverter());
					return JsonConvert.DeserializeObject<T>(content, new BoolConverter());
				}
				else
				{
					throw new HttpRequestException("No data returned");
				}
			}
			else
			{
				throw new HttpRequestException(response.ReasonPhrase);
			}
		}
	}
}