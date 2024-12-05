namespace sevillaMath;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();
	}

    private void btnInmediatas_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InInmediatas(),true);
    }
}