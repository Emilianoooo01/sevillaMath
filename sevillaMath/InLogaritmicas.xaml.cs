namespace sevillaMath;

public partial class InLogaritmicas : ContentPage
{
    private readonly BDService _databaseService;
    public InLogaritmicas(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }
}