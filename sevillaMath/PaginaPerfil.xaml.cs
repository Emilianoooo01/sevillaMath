using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace sevillaMath;

public partial class PaginaPerfil : ContentPage
{
    private readonly BDService _databaseService;
    public PaginaPerfil(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
        CargarPerfil();
    }

    private async void CargarPerfil()
    {
        string nombreUsuario = SesionUsuario.NombreUsuario;
        NombreUsuarioLabel.Text = nombreUsuario;

        var intentos = await _databaseService.ObtenerIntentosPorUsuarioAsync(nombreUsuario);

        var puntajes = intentos.Select(i => new
        {
            Tema = ObtenerNombreTema(i.TemaId),
            Puntuacion = $"{i.Puntuacion} %"
        }).ToList();

        PuntajesCollectionView.ItemsSource = puntajes;
    }

    private string ObtenerNombreTema(int temaId)
    {
        return temaId switch
        {
            1 => "Integrales Inmediatas",
            2 => "Integrales Logaritmicas",
            3 => "Integrales por Partes",
            4 => "Integrales Explicitas",
            5 => "Integrales Parciales",
            _ => "Tema Desconocido"
        };
    }

    private void ContentPage_Disappearing(object sender, EventArgs e)
    {
        //Cambio de color de la barra de notificaciones (Android)
        this.Behaviors.Add(new StatusBarBehavior
        {
            StatusBarColor = Color.FromHex("#F1EFEF"),
            StatusBarStyle = StatusBarStyle.DarkContent
        });
    }
}