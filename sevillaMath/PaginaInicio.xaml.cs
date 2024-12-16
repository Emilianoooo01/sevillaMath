using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;

namespace sevillaMath;

public partial class PaginaInicio : ContentPage
{
    private readonly BDService _databaseService;
    public ObservableCollection<Video> Videos { get; set; }
    public string VideoUrl { get; set; }

    public PaginaInicio(BDService databaseService)
	{
		InitializeComponent();

        _databaseService = databaseService;

        Videos = new ObservableCollection<Video>
        {
            new Video { Titulo = "Explicando Integrales", Miniatura = "video1.jpg"  = "https://example.com/video1.mp4"},
            new Video { Titulo = "Video 2", Miniatura = "video2.jpg" },
        };

        BindingContext = this;

    }

    //Cursos
    private void btnInmediatas_Clicked(object sender, EventArgs e)
    {
        var InInmediatas = new InInmediatas(_databaseService);
        Navigation.PushAsync(InInmediatas,true);
    }

    private void btnLogaritmicas_Clicked(object sender, EventArgs e)
    {
        var InLogaritmicas = new InLogaritmicas(_databaseService);
        Navigation.PushAsync(InLogaritmicas, true);
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

    //Barra
    private void btnPerfil_Clicked(object sender, EventArgs e)
    {
        var PaginaPerfil = new PaginaPerfil(_databaseService);
        Navigation.PushModalAsync(PaginaPerfil, true);
    }

    public class Video
    {
        public string Titulo { get; set; }
        public string Miniatura { get; set; }
        public string VideoUrl { get; set; }
        public Command AbrirVideoCommand { get; set; }

        public Video()
        {
            AbrirVideoCommand = new Command(() =>
            {
                Launcher.Default.OpenAsync(VideoUrl);
            });
        }
    }

}