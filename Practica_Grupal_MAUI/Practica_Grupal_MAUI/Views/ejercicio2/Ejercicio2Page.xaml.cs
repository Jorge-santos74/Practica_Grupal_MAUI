namespace Practica_Grupal_MAUI.Views.ejercicio2;

public partial class Ejercicio2Page : ContentPage
{
    public Ejercicio2Page()
    {
        InitializeComponent();
    }

    private async void OnIniciarClicked(object sender, EventArgs e)
    {
        // Deshabilitamos el botón para evitar que el usuario inicie múltiples conteos a la vez
        BtnIniciar.IsEnabled = false;

        // Bucle en reversa desde 10 hasta 1
        for (int i = 10; i >= 1; i--)
        {
            LblContador.Text = i.ToString();

            // Pausa la ejecución por 1000 milisegundos (1 segundo)
            await Task.Delay(1000);
        }

        LblContador.Text = "¡Despegue!";

        // Volvemos a habilitar el botón
        BtnIniciar.IsEnabled = true;
    }
}