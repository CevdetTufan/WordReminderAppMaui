using WordReminderAppMaui.Models;

namespace WordReminderAppMaui.Services
{
	public interface IUserService
	{
		Task<UserLoginResponseModel> Login(UserLoginRequestModel req);
	}
}
