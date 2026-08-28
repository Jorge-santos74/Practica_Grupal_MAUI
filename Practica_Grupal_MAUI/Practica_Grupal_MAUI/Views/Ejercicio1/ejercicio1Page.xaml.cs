namespace Practica_Grupal_MAUI.Views.Ejercicio1;

public partial class ejercicio1Page : ContentPage
{
    public ejercicio1Page()
    {
        InitializeComponent();
    }

    private void OnGenerarClicked(object sender, EventArgs e)
    {
        // Usamos una lista para ir guardando los números
        List<int> pares = new List<int>();

        // El bucle inicia en 0, llega hasta 100, sumando 2 en cada iteración
        for (int i = 0; i <= 100; i += 2)
        {
            pares.Add(i);
        }

        // Unimos los números con una coma y espacio, y los pasamos al Label
        LblResultados.Text = string.Join(", ", pares);
    }
}