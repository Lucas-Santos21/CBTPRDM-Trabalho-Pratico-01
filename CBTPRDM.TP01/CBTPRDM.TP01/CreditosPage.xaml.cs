//Nome e prontuário da dupla:
//Lucas da Silva Santos CB3030598
//Kaueh Farias Ferreira dos Santos CB3031438

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