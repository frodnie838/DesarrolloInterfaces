namespace PrimeraApp
{
    public partial class MainPage : ContentPage
    {        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina1());
        }

        private void Galeria(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina2());
        }

        private void FlexLayout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaFlexL());
        }
    }
}
