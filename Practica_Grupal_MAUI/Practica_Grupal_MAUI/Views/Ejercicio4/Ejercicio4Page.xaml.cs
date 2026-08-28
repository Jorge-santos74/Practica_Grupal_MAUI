using Microsoft.Maui.Graphics;

namespace Practica_Grupal_MAUI.Views.Ejercicio4;

public partial class Ejercicio4Page : ContentPage
{
    public Ejercicio4Page()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(TxtHorasTrabajadas.Text, out double horas) &&
            double.TryParse(TxtPagoPorHora.Text, out double pagoHora))
        {
            if (horas >= 0 && pagoHora >= 0)
            {
                double sueldoTotal = horas * pagoHora;
                LblResultado.Text = $"Sueldo semanal: ${sueldoTotal:N2}";
                LblResultado.TextColor = Colors.Green;
            }
            else
            {
                LblResultado.Text = "Los valores deben ser positivos.";
                LblResultado.TextColor = Colors.Red;
            }
        }
        else
        {
            LblResultado.Text = "Por favor, ingresa números válidos.";
            LblResultado.TextColor = Colors.Red;
        }
    }
}