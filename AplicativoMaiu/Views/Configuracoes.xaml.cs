namespace AplicativoMaiu;


public partial class Configuracoes : ContentPage
{
    public Configuracoes()
    {
        InitializeComponent();
    }

	

private void DesativarNotificacoes_Clicked(object sender, EventArgs e)
{
    // Cancela todas as notifica��es programadas

    // Exibe uma mensagem informando que as notifica��es foram desativadas
    DisplayAlert("Notifica��es", "Todas as notifica��es foram desativadas.", "OK");
}

}