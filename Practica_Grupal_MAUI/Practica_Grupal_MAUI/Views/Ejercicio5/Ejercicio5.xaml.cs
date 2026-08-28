namespace Practica_Grupal_MAUI.Views.Ejercicio5;

public partial class Ejercicio5 : ContentPage
{
    public Ejercicio5()
    {
        InitializeComponent();
    }

    private async void btnCalcular_Clicked(object sender, EventArgs e)
    {
        // Validar que se haya ingresado un dato
        if (string.IsNullOrWhiteSpace(txtPersonas.Text))
        {
            await DisplayAlert(
                "Error",
                "Ingrese el número de personas.",
                "Aceptar");

            txtPersonas.Focus();
            return;
        }

        // Validar que sea un número entero
        if (!int.TryParse(txtPersonas.Text, out int personas))
        {
            await DisplayAlert(
                "Error",
                "Ingrese solamente números.",
                "Aceptar");

            txtPersonas.Focus();
            return;
        }

        // Validar que sea mayor que cero
        if (personas <= 0)
        {
            await DisplayAlert(
                "Error",
                "El número de personas debe ser mayor que 0.",
                "Aceptar");

            txtPersonas.Focus();
            return;
        }

        // Determinar el costo por persona
        decimal precioPorPersona;

        if (personas <= 200)
        {
            precioPorPersona = 95.00m;
        }
        else if (personas <= 300)
        {
            precioPorPersona = 85.00m;
        }
        else
        {
            precioPorPersona = 75.00m;
        }

        // Calcular presupuesto
        decimal presupuesto = personas * precioPorPersona;

        // Mostrar resultados
        lblCantidad.Text = personas.ToString();

        lblPrecio.Text = "$" + precioPorPersona.ToString("0.00");

        lblTotal.Text = "$" + presupuesto.ToString("0.00");
    }
}