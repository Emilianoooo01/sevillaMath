namespace sevillaMath;

public partial class PaginaVideo : ContentPage
{

    public PaginaVideo(Video video)
	{
		InitializeComponent();

        BindingContext = video; 
    }
}