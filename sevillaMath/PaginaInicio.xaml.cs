using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

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
            new Video { Titulo = "Teorema fundamental", Miniatura = "video1.jpg", VideoUrl = "https://www.youtube.com/embed/SCKpUCax5ss?si=VGHoKF5cypiWRdd7%22%20title=", Descripcion="Explicación del concepto de integral definida y cómo se representa matemáticamente. Luego, se resuelve un ejemplo sencillo: la integral definida de x² entre los límites de integración 1 y 2.\r\n\r\nEl presentador explica paso a paso el proceso de resolución, comenzando por la integración de la función utilizando la regla de la potencia. Se destaca que en las integrales definidas no es necesario incluir la constante de integración (C). A continuación, se aplica el Teorema Fundamental del Cálculo, que establece que el valor de la integral definida es igual a la diferencia entre el valor de la función evaluada en el límite superior de integración y el valor de la función evaluada en el límite inferior de integración."},

            new Video { Titulo = "Integrales Definidas", Miniatura = "video2.jpg", VideoUrl = "https://www.youtube.com/embed/tqbmfCDW3lM?si=Qctnjbyfm1ZCMA2v%22%20title=", Descripcion="Tutorial introductorio sobre cómo resolver integrales definidas. El presentador guía a los espectadores a través de dos ejemplos sencillos: la integral definida de 2x entre los límites de integración 3 y 5, y la integral definida de la constante 5 entre los límites de integración 1 y 4.\r\n\r\nEn cada ejemplo, el presentador explica paso a paso el proceso de resolución, comenzando por la integración de la función y luego aplicando los límites de integración. Se enfatiza la importancia de reemplazar la variable de integración con los límites superior e inferior y realizar la resta correspondiente." },

            new Video { Titulo = "Qué es la integral", Miniatura = "video3.jpg", VideoUrl = "https://www.youtube.com/embed/M3Zx9a9gO0c?si=hhlMp6noG_F9im5K", Descripcion="Introducción conceptual a las integrales, explorando su significado y utilidad. Se inicia estableciendo la integral como una herramienta para medir, comparando este proceso con la medición de longitudes y superficies.\r\n\r\nSe destaca que la integral permite calcular el área bajo una curva, incluso cuando esta presenta límites curvos. Se ilustra este concepto a través de la aproximación de áreas mediante rectángulos, siguiendo el método histórico de Arquímedes."},

            new Video { Titulo = "Para qué sirve el calculo integral", Miniatura = "video4.jpg", VideoUrl = "https://www.youtube.com/embed/_w9Zv7VUAmk?si=C3NaadJRzc6Yy-t7", Descripcion="Se plantea un escenario donde un depósito de agua se llena a una velocidad variable descrita por la función f(t) = 0.5t + 10 litros/minuto, donde t representa el tiempo en minutos. El objetivo es calcular la cantidad de agua que ingresa al depósito entre los minutos 40 y 100.\r\n\r\nEl video explica cómo el cálculo integral permite resolver este problema. Se introduce el concepto de integral definida como la suma de áreas infinitesimales bajo la curva de la función de velocidad. Se muestra cómo la integral definida de f(t) entre los límites de integración 40 y 100 representa la cantidad de agua acumulada en ese intervalo."},

            new Video { Titulo = "Qué es la integral", Miniatura = "video5.jpg", VideoUrl = "https://www.youtube.com/embed/M3Zx9a9gO0c?si=hhlMp6noG_F9im5K", Descripcion="introducción conceptual a las integrales, explorando su significado y utilidad. Se inicia estableciendo la integral como una herramienta para medir, comparando este proceso con la medición de longitudes y superficies.\r\n\r\nSe destaca que la integral permite calcular el área bajo una curva, incluso cuando esta presenta límites curvos. Se ilustra este concepto a través de la aproximación de áreas mediante rectángulos, siguiendo el método histórico de Arquímedes."},

            new Video { Titulo = "Para qué sirve el calculo integral", Miniatura = "video6.jpg", VideoUrl = "https://www.youtube.com/embed/_w9Zv7VUAmk?si=C3NaadJRzc6Yy-t7", Descripcion="Se plantea un escenario donde un depósito de agua se llena a una velocidad variable descrita por la función f(t) = 0.5t + 10 litros/minuto, donde t representa el tiempo en minutos. El objetivo es calcular la cantidad de agua que ingresa al depósito entre los minutos 40 y 100.\r\n\r\nEl video explica cómo el cálculo integral permite resolver este problema. Se introduce el concepto de integral definida como la suma de áreas infinitesimales bajo la curva de la función de velocidad. Se muestra cómo la integral definida de f(t) entre los límites de integración 40 y 100 representa la cantidad de agua acumulada en ese intervalo."},
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

    private void btnFormulas_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PaginaFormulas(), true);
    }
}