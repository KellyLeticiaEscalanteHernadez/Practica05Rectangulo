namespace Practica05Rectangulo;

public partial class Rectangulo : ContentPage
{
    public Rectangulo()
    {
        InitializeComponent();
    }
    private void OnCalculatePerimeterClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Altura.Text))
        {
            double perimetro, baseValue, AlturaValue;
            baseValue=Convert.ToDouble(Base.Text);
            AlturaValue = Convert.ToDouble(Altura.Text);
            perimetro = 2 * (baseValue + AlturaValue);
            Resultado.Text = $"El perímetro del rectángulo es {perimetro}.";
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese valores numéricos positivos para la base y la altura.", "OK");
        }
    }
    private void OnCalculateAreaClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Base.Text) && !string.IsNullOrEmpty(Altura.Text))
        {
            double area, baseValue, AlturaValue;    
            baseValue=Convert.ToDouble(Base.Text);
            AlturaValue = Convert.ToDouble(Altura.Text);
            area = baseValue * AlturaValue;
            Resultado.Text = $"La superficie del rectángulo es {area}.";
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese valores numéricos positivos para la base y la altura.", "OK");
        }
    }
}
