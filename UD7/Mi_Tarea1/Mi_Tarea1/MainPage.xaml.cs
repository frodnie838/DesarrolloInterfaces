namespace Mi_Tarea1
{
    public partial class MainPage : ContentPage
    {
        private decimal cuenta;
        private int propina;
        private int personas = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularTotal()
        {
            // Propina total
            var propinaTotal = cuenta * propina / 100;
            // Propina por persona
            var propinaPorPersona = propinaTotal / personas;
            lblPropinaPorPersona.Text = $"{propinaPorPersona:C}";

            // Subtotal
            var subtotal = cuenta / personas;
            lblSubtotal.Text = $"{subtotal:C}";

            // Total
            var totalPorPersona = (cuenta + propinaTotal) / personas;
            lblTotal.Text = $"{totalPorPersona:C}";
        }

        private void TxtCuenta_Completed(object sender, EventArgs e)
        {            
            if (decimal.TryParse(txtCuenta.Text, out cuenta)) { } else cuenta = 0;
            CalcularTotal();
        }

        private void SldPropina_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            propina = (int)sldPropina.Value;
            lblPropina.Text = propina.ToString();
            CalcularTotal();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(sender is Button) {
                var btn = (Button)sender;
                var porcentaje = int.Parse(btn.Text.Replace("%", string.Empty));
                sldPropina.Value = porcentaje;
            }
        }

        private void BtnMenos_Clicked(object sender, EventArgs e)
        {
            if (personas > 1)
            {
                personas += -1;
                lblPersonas.Text = personas.ToString();
                CalcularTotal();
            }
        }

        private void BtnMas_Clicked(object sender, EventArgs e)
        {
           
            personas += +1;
            lblPersonas.Text = personas.ToString();
            CalcularTotal();
            
        }
    }
}
