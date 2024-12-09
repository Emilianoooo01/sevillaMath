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

    private async void btnInicioSesion_Clicked(object sender, EventArgs e)
    {
        //Boton Inicio de Sesión
        string usuario = entUsuario.Text;
        string contrasena = entContraseña.Text;

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
            SesionUsuario.NombreUsuario = usuarioValido.NombreUsuario;
            var paginaInicio = new PaginaInicio(_databaseService);
            await Navigation.PushAsync(paginaInicio);
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private void btnCrear_Clicked(object sender, EventArgs e)
    {
        //Boton Registro
        var PaginaRegistro = new PaginaRegistro(_databaseService);
        Navigation.PushModalAsync(PaginaRegistro, true);
    }
}