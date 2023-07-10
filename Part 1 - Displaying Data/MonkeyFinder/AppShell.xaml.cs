namespace MonkeyFinder;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // name of the route and the page to load is called 'DetailsPage'
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}