namespace CBTPRDM.TP01;

public partial class CreditosPage : ContentPage
{
	public CreditosPage()
	{
		InitializeComponent();
	}

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        // O PopAsync remove a página atual da pilha de navegação, voltando para a anterior
        await Navigation.PopAsync();
    }
}