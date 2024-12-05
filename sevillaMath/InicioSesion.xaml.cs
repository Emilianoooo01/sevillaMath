namespace sevillaMath;

public partial class InicioSesion : ContentPage
{

    private readonly BDService _databaseService;

    public InicioSesion()
	{
		InitializeComponent();
        string dbPath = Path.Combine(FileSystem.AppDataDirectory,"usuarios.db");
        _databaseService = new BDService(dbPath);
    }

    public void AbrirPaginaInicio()
    {
        Navigation.PushAsync(new PaginaInicio());
    }

    private async void btnInicioSesion_Clicked(object sender, EventArgs e)
    {
        //Boton Inicio de Sesi�n
        string usuario = entUsuario.Text;
        string contrasena = entContrase�a.Text;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            return;
        }

        // Verificar si el usuario existe en la base de datos
        var usuarioEncontrado = await _databaseService.ObtenerUsuariosAsync();
        var usuarioValido = usuarioEncontrado.FirstOrDefault(u => u.NombreUsuario == usuario && u.Contrasena == contrasena);

        if (usuarioValido != null)
        {
            await Navigation.PushAsync(new PaginaInicio(), true);
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
        }
    }

    private void btnCrear_Clicked(object sender, EventArgs e)
    {
        //Boton Registro
        var PaginaRegistro = new PaginaRegistro(_databaseService);
        Navigation.PushModalAsync(PaginaRegistro, true);
    }
}