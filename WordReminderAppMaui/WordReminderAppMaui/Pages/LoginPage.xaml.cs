namespace WordReminderAppMaui.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private void btnLogin_Clicked(object sender, EventArgs e)
	{
		string userName = txtUserName.Text;
		string password = txtPassword.Text;

		if(userName == null || password == null)
		{
			DisplayAlert("Warning", "Please input Username & Password", "Ok");
		}
	}
}