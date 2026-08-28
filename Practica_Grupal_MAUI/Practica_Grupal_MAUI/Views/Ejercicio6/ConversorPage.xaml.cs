using System.Globalization;

namespace Practica_Grupal_MAUI.Views.Ejercicio6;

public partial class ConversorPage : ContentPage
{
    public ConversorPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        string textoPesos = EntryPesos.Text?.Trim() ?? string.Empty;
        string textoTasa = EntryTasa.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(textoPesos) || string.IsNullOrWhiteSpace(textoTasa))
        {
            await DisplayAlert("Atención", "Por favor ingrese tanto el monto como la tasa de cambio.", "Aceptar");
            return;
        }

        bool esPesosValido = double.TryParse(textoPesos, NumberStyles.Number, CultureInfo.InvariantCulture, out double pesos);
        bool esTasaValida = double.TryParse(textoTasa, NumberStyles.Number, CultureInfo.InvariantCulture, out double tasaCambio);

        if (!esPesosValido || !esTasaValida)
        {
            await DisplayAlert("Error de Formato", "Ingrese únicamente valores numéricos válidos.", "Aceptar");
            return;
        }

        if (pesos <= 0 || tasaCambio <= 0)
        {
            await DisplayAlert("Monto Inválido", "Los valores ingresados deben ser mayores a cero.", "Aceptar");
            return;
        }

        double dolares = pesos / tasaCambio;

        LabelResultado.Text = $"${dolares:N2} USD";
        LabelDetalle.Text = $"Equivalencia de ${pesos:N2} MXN a ${tasaCambio:N2} MXN/USD.";
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        EntryPesos.Text = string.Empty;
        EntryTasa.Text = "18.50";
        LabelResultado.Text = "$0.00 USD";
        LabelDetalle.Text = "Ingrese un monto para realizar el cálculo.";
        EntryPesos.Focus();
    }
}