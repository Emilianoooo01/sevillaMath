using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;

namespace sevillaMath;

public partial class PaginaInicio : ContentPage
{
    private readonly BDService _databaseService;
    public ObservableCollection<Video> Videos { get; set; }

    public PaginaInicio(BDService databaseService)
	{
		InitializeComponent();

        _databaseService = databaseService;

        Videos = new ObservableCollection<Video>
        {
            new Video { Titulo = "Video 1", Miniatura = "video1.jpg" },
            new Video { Titulo = "Video 2", Miniatura = "video2.jpg" },
            new Video { Titulo = "Video 3", Miniatura = "video3.jpg" },
            new Video { Titulo = "Video 4", Miniatura = "video40.jpg" },
            // Agregar mas
        };

        BindingContext = this;

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

    public class Video
    {
        public string Titulo { get; set; }
        public string Miniatura { get; set; }
    }

    private void btnPorPartes_Clicked(object sender, EventArgs e)
    {

    }

    private void btnExplicitas_Clicked(object sender, EventArgs e)
    {

    }

    private void btnFracciones_Clicked(object sender, EventArgs e)
    {

    }
}