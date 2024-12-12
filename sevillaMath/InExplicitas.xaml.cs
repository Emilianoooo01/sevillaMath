namespace sevillaMath;

public partial class InExplicitas : ContentPage
{
    private readonly BDService _databaseService;
    public InExplicitas(BDService databaseService)
	{
		InitializeComponent();
        _databaseService = databaseService;
    }
}