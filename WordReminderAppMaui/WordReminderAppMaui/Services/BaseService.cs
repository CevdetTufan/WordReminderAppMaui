namespace WordReminderAppMaui.Services
{
	public abstract class BaseService
	{
		public virtual async Task<string> GetAsync(string url)
		{
			using var client = new HttpClient();
			client.BaseAddress = new Uri(url);

			HttpResponseMessage response = await client.GetAsync(url);

			response.EnsureSuccessStatusCode();

			string content = response.Content.ReadAsStringAsync().Result;

			return content;
		}

		public virtual async Task<string> PostAsync(string apiUrl, string requestBody)
		{
			using var client = new HttpClient();
			var content = new StringContent(requestBody, System.Text.Encoding.UTF8, "application/json");
			HttpResponseMessage response = await client.PostAsync(apiUrl, content);
			response.EnsureSuccessStatusCode();

			string responseContent = await response.Content.ReadAsStringAsync();

			return responseContent;
		}
	}
}
