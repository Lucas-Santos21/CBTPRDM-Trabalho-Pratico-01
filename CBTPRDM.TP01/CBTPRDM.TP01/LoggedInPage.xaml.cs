//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

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