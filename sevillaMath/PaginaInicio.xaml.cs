namespace sevillaMath;

public partial class PaginaInicio : ContentPage
{
	public PaginaInicio()
	{
		InitializeComponent();
	}

    //Cursos
    private void btnInmediatas_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new InInmediatas(),true);
    }

    private void btnLogaritmicas_Clicked(object sender, EventArgs e)
    {

    }

    //Barra
    private void btnPerfil_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PaginaPerfil(), true);
    }

    private void btnPrueba_Clicked(object sender, EventArgs e)
    {

    }
}