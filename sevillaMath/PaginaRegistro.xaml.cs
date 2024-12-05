using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace sevillaMath;

public partial class PaginaRegistro : ContentPage
{
    private readonly BDService _databaseService;

    public PaginaRegistro(BDService databaseService)
	{
		InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "usuarios.db");
        _databaseService = new BDService(dbPath);
    }

    private async void btnCrearCuenta_Clicked(object sender, EventArgs e)
    {
        //Boton crear cuenta
        string usuario = entUsuario.Text;
        string contrasena = entContraseña.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        var nuevoUsuario = new BDUsuario
        {
            NombreUsuario = usuario,
            Contrasena = contrasena
        };

        await _databaseService.GuardarUsuarioAsync(nuevoUsuario);
        await DisplayAlert("Registro", $"Usuario {usuario} registrado correctamente.", "OK");
        await Navigation.PopModalAsync(true);
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