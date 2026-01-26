namespace PrimeraApp;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}
    private void Volver(object sender, EventArgs e)
    {

        Navigation.PushAsync(new MainPage());
    }
}