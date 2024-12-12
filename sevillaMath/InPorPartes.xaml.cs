namespace sevillaMath;

public partial class InPorPartes : ContentPage
{
    private readonly BDService _databaseService;
    public InPorPartes(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }
}