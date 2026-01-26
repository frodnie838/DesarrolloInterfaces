namespace PrimeraApp;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
    }

    private void Volver(object sender, EventArgs e)
    {

        Navigation.PushAsync(new MainPage());
    }
}