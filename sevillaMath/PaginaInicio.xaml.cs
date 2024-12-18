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
            new Video { Titulo = "Teorema fundamental", Miniatura = "video1.jpg", VideoUrl = "https://www.youtube.com/embed/SCKpUCax5ss?si=VGHoKF5cypiWRdd7%22%20title=", Descripcion="Explicaci�n del concepto de integral definida y c�mo se representa matem�ticamente. Luego, se resuelve un ejemplo sencillo: la integral definida de x� entre los l�mites de integraci�n 1 y 2.\r\n\r\nEl presentador explica paso a paso el proceso de resoluci�n, comenzando por la integraci�n de la funci�n utilizando la regla de la potencia. Se destaca que en las integrales definidas no es necesario incluir la constante de integraci�n (C). A continuaci�n, se aplica el Teorema Fundamental del C�lculo, que establece que el valor de la integral definida es igual a la diferencia entre el valor de la funci�n evaluada en el l�mite superior de integraci�n y el valor de la funci�n evaluada en el l�mite inferior de integraci�n."},

            new Video { Titulo = "Integrales Definidas", Miniatura = "video2.jpg", VideoUrl = "https://www.youtube.com/embed/tqbmfCDW3lM?si=Qctnjbyfm1ZCMA2v%22%20title=", Descripcion="Tutorial introductorio sobre c�mo resolver integrales definidas. El presentador gu�a a los espectadores a trav�s de dos ejemplos sencillos: la integral definida de 2x entre los l�mites de integraci�n 3 y 5, y la integral definida de la constante 5 entre los l�mites de integraci�n 1 y 4.\r\n\r\nEn cada ejemplo, el presentador explica paso a paso el proceso de resoluci�n, comenzando por la integraci�n de la funci�n y luego aplicando los l�mites de integraci�n. Se enfatiza la importancia de reemplazar la variable de integraci�n con los l�mites superior e inferior y realizar la resta correspondiente." },

            new Video { Titulo = "Qu� es la integral", Miniatura = "video3.jpg", VideoUrl = "https://www.youtube.com/embed/M3Zx9a9gO0c?si=hhlMp6noG_F9im5K", Descripcion="Introducci�n conceptual a las integrales, explorando su significado y utilidad. Se inicia estableciendo la integral como una herramienta para medir, comparando este proceso con la medici�n de longitudes y superficies.\r\n\r\nSe destaca que la integral permite calcular el �rea bajo una curva, incluso cuando esta presenta l�mites curvos. Se ilustra este concepto a trav�s de la aproximaci�n de �reas mediante rect�ngulos, siguiendo el m�todo hist�rico de Arqu�medes."},

            new Video { Titulo = "Para qu� sirve el calculo integral", Miniatura = "video4.jpg", VideoUrl = "https://www.youtube.com/embed/_w9Zv7VUAmk?si=C3NaadJRzc6Yy-t7", Descripcion="Se plantea un escenario donde un dep�sito de agua se llena a una velocidad variable descrita por la funci�n f(t) = 0.5t + 10 litros/minuto, donde t representa el tiempo en minutos. El objetivo es calcular la cantidad de agua que ingresa al dep�sito entre los minutos 40 y 100.\r\n\r\nEl video explica c�mo el c�lculo integral permite resolver este problema. Se introduce el concepto de integral definida como la suma de �reas infinitesimales bajo la curva de la funci�n de velocidad. Se muestra c�mo la integral definida de f(t) entre los l�mites de integraci�n 40 y 100 representa la cantidad de agua acumulada en ese intervalo."},

            new Video { Titulo = "Integrales Trigonometricas", Miniatura = "video5.jpg", VideoUrl = "https://www.youtube.com/embed/eR5JJfbqLwA?si=J8DGOcivz_2Y0VK_", Descripcion="Explica c�mo resolver una integral definida trigonom�trica. La Prof Lina comienza simplificando la expresi�n utilizando propiedades de la potenciaci�n y una identidad trigonom�trica. Luego, aplica la propiedad distributiva y separa la integral en dos partes.\r\n\r\nA continuaci�n, utiliza la t�cnica de integraci�n por sustituci�n, reemplazando el seno de x por una nueva variable (u). Cambia los l�mites de integraci�n de acuerdo con la sustituci�n."},

            new Video { Titulo = "Integral Logaritmicas", Miniatura = "video6.jpg", VideoUrl = "https://www.youtube.com/embed/M_eqktMoHz8?si=IPDBbx-9nDtTn9pm", Descripcion="Explica c�mo calcular integrales logar�tmicas. Se comienza con la integral b�sica de 1/x, que es igual al logaritmo natural de x m�s una constante. Luego, se presenta un ejemplo m�s complejo donde el denominador es una funci�n cuadr�tica.\r\n\r\nPara resolver este tipo de integrales, se busca manipular la expresi�n para que se ajuste a la forma de la integral b�sica. En este caso, se multiplica y divide por un factor constante para obtener la derivada del denominador en el numerador.\r\n\r\nFinalmente, se aplica la f�rmula de la integral logar�tmica y se obtiene la soluci�n. El video enfatiza la importancia de reconocer la forma b�sica de la integral logar�tmica y de buscar estrategias para manipular la expresi�n a fin de poder aplicarla."},
        };

        BindingContext = this;

    }

    //Cursos
    private void btnHistoria_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InHistoria(), true);
    }

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

    private void btnTrigonometricas_Clicked(object sender, EventArgs e)
    {
        var InTrigonometricas = new InTrigonometricas(_databaseService);
        Navigation.PushAsync(InTrigonometricas, true);
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