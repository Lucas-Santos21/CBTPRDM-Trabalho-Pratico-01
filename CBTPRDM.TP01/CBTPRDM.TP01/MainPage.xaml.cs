namespace CBTPRDM.TP01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOkClicked(object sender, EventArgs e)
        {
            // Validação de usuário
            if (IdEntry.Text == "admin" && PassEntry.Text == "senha@dmin")
            {
                // Redirecionando para a página de usuario logado
                await Navigation.PushAsync(new LoggedInPage());
            }
            else
            {
                // Mensagem de erro caso os dados estejam incorretos
                await DisplayAlert("Erro", "login não autorizado", "OK");
            }
        }

        private void OnLimparClicked(object sender, EventArgs e)
        {
            // Limpa os campos
            IdEntry.Text = string.Empty;
            PassEntry.Text = string.Empty;

            // Reposiciona o cursor no primeiro campo
            IdEntry.Focus();
        }

        private async void OnCreditosClicked(object sender, EventArgs e)
        {
            // Navega para a página de créditos
            await Navigation.PushAsync(new CreditosPage());
        }
    }
}
