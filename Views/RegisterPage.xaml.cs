namespace AppMusic.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void Login(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }

}