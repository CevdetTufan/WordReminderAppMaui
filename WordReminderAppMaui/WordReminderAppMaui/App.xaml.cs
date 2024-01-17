using WordReminderAppMaui.Pages;

namespace WordReminderAppMaui
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new LoginPage());
		}
	}
}
