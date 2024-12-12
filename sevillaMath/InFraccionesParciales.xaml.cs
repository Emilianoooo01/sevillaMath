namespace sevillaMath;

public partial class InFraccionesParciales : ContentPage
{
    private readonly BDService _databaseService;
    public InFraccionesParciales(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }
}