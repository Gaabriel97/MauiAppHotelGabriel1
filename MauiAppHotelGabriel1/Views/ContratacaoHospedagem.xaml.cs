namespace MauiAppHotelGabriel1.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
    {
        InitializeComponent();
    }
    private async void OnButtonClicked(object sender, EventArgs e) { await Navigation.PushAsync(new Sobre()); }
}

