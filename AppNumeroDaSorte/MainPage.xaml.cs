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

		SortedSet<int> luckNumbers = GenerateLuckNumbers();

		NumberOne.Text = luckNumbers.ElementAt(0).ToString("D2");
        NumberTwo.Text = luckNumbers.ElementAt(1).ToString("D2");
        NumberThree.Text = luckNumbers.ElementAt(2).ToString("D2");
        NumberFour.Text = luckNumbers.ElementAt(3).ToString("D2");
        NumberFive.Text = luckNumbers.ElementAt(4).ToString("D2");
        NumberSix.Text = luckNumbers.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLuckNumbers()
	{
		SortedSet<int> luckNumbers = new();
		Random random = new();

		while(luckNumbers.Count < 6)
		{
			int luckNumber = random.Next(1, 60);

            luckNumbers.Add(luckNumber);
        }
		
		return luckNumbers;
	}
}