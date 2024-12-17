namespace sevillaMath;

public partial class InTrigonometricas : ContentPage
{
    private readonly BDService _databaseService;
    public InTrigonometricas(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }
}