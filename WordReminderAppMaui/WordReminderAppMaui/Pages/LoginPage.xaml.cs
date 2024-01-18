using WordReminderAppMaui.Services;

namespace WordReminderAppMaui.Pages;

public partial class LoginPage : ContentPage
{
	private readonly IUserService userService;
	public LoginPage()
	{
		InitializeComponent();
		this.userService = new UserService();
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
		string userName = txtUserName.Text;
		string password = txtPassword.Text;

		if(string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
		{
			DisplayAlert("Warning", "Please input Username & Password", "Ok");
		}

		userService.Login(new Models.UserLoginRequestModel { Username=userName,Password=password });
	}
}