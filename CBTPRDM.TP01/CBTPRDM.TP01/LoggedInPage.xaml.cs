namespace CBTPRDM.TP01;

public partial class LoggedInPage : ContentPage
{
	public LoggedInPage()
	{
		InitializeComponent();
	}

    private async void OnSairClicked(object sender, EventArgs e)
    {
        // Retorna para a página de login
        await Navigation.PopAsync();
    }
}