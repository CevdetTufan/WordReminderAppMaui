using Newtonsoft.Json;
using WordReminderAppMaui.Helpers;
using WordReminderAppMaui.Models;

namespace WordReminderAppMaui.Services
{
	public class UserService : BaseService, IUserService
	{
		public async Task<UserLoginResponseModel> Login(UserLoginRequestModel req)
		{
			try
			{
				var endpoint = new EndpointBuilder(baseUrl: "http://localhost:1064");

				string url = endpoint.Apend("auth").Apend("login").Build();
				string requestBody=JsonConvert.SerializeObject(req);


				var response= await PostAsync(url, requestBody);
			}
			catch (Exception ex)
			{

				throw;
			}

			return new UserLoginResponseModel();
		}
	}
}
