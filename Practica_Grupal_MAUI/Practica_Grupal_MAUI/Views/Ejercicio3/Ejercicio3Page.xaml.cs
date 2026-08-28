using Microsoft.Maui.Graphics;

namespace Practica_Grupal_MAUI.Views.Ejercicio3;

public partial class Ejercicio3Page : ContentPage
{
    public Ejercicio3Page()
    {
        InitializeComponent();
    }

    private void OnTablaChanged(object sender, EventArgs e)
    {
        ContainerResultados.Children.Clear();
        int selectedIndex = PickerTabla.SelectedIndex;

        if (selectedIndex == -1) return;

        if (selectedIndex == 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                GenerarTabla(i);
            }
        }
        else
        {
            int numeroTabla = selectedIndex + 1;
            GenerarTabla(numeroTabla);
        }
    }

    private void GenerarTabla(int numero)
    {
        var frame = new Border
        {
            Stroke = Colors.LightGray,
            Padding = 15,
            Margin = new Thickness(0, 5)
        };

        var stack = new VerticalStackLayout { Spacing = 5 };

        stack.Children.Add(new Label
        {
            Text = $"Tabla del {numero}",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            TextColor = Colors.Blue
        });

        for (int i = 1; i <= 10; i++)
        {
            stack.Children.Add(new Label
            {
                Text = $"{numero} x {i} = {numero * i}",
                FontSize = 16
            });
        }

        frame.Content = stack;
        ContainerResultados.Children.Add(frame);
    }
}