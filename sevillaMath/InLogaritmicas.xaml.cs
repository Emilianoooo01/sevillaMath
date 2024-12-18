namespace sevillaMath;

public partial class InLogaritmicas : ContentPage
{
    private readonly BDService _databaseService;
    public InLogaritmicas(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }

    private void OnVerUnoButton_Clicked(object sender, EventArgs e)
    {
        VerUno.IsVisible = true;
    }

    private void OnVerDosButton_Clicked(object sender, EventArgs e)
    {
        VerDos.IsVisible = true;
    }

    private async void OnVerificarLogButton_Clicked(object sender, EventArgs e)
    {
        string nombreUsuario = SesionUsuario.NombreUsuario;
        int temaId = 2;
        const int limiteDiasTema = 3;


        var intento = await _databaseService.ObtenerIntentoPorUsuarioYTemaAsync(nombreUsuario, temaId);

        if (intento == null)
        {
            intento = new FormularioIntento
            {
                NombreUsuario = nombreUsuario,
                TemaId = temaId,
                FechaInicio = DateTime.Now,
                FechaIntento = DateTime.Now,
                NumeroIntentos = 0,
                DiasEnTema = 0,
                Puntuacion = 0,
                PasoFormulario = false
            };
            await _databaseService.GuardarIntentoAsync(intento);
        }

        int diasTranscurridos = (DateTime.Now - intento.FechaInicio).Days;

        if (diasTranscurridos < limiteDiasTema - 1)
        {
            await DisplayAlert("Acceso Restringido", $"A�n no puedes responder el formulario. Faltan {limiteDiasTema - diasTranscurridos - 1} dias.", "OK");
            return;
        }
        else if (diasTranscurridos == limiteDiasTema - 1)
        {
            await DisplayAlert("Acceso Permitido", "Hoy puedes responder el formulario.", "OK");
        }
        else
        {
            await DisplayAlert("Tiempo Agotado", "El tiempo para responder este tema ha expirado.", "OK");
            return;
        }

        int correctAnswers = 0;

        if (OpA4.IsChecked)
        {
            correctAnswers++;
        }
        if (OpB1.IsChecked)
        {
            correctAnswers++;
        }

        VerLog.Text = $"Respuestas correctas: {correctAnswers} de 2";

        double score = (correctAnswers / 2.0) * 100;

        intento.FechaIntento = DateTime.Now;
        intento.NumeroIntentos++;
        intento.Puntuacion = score;
        intento.PasoFormulario = score >= 60;

        await _databaseService.GuardarIntentoAsync(intento);

        if (score >= 60)
        {
            await DisplayAlert("Felicidades!", "Has pasado el tema. Avanzando al siguiente.", "OK");
            await Navigation.PushAsync(new InLogaritmicas(_databaseService));
        }
        else
        {
            await DisplayAlert("Intenta de nuevo", "No alcanzaste el puntaje minimo para avanzar.", "OK");
        }
    }
}