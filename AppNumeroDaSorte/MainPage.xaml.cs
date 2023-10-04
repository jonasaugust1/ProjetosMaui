namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
        ((Button)sender).Text = "Gerar outro número da sorte";

        AppName.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;
	}
}