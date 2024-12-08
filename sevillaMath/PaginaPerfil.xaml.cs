using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;

namespace sevillaMath;

public partial class PaginaPerfil : ContentPage
{
	public PaginaPerfil()
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