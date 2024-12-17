using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace sevillaMath;

public partial class PaginaFormulas : ContentPage
{
	public PaginaFormulas()
	{
		InitializeComponent();
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