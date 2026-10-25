namespace KpiTracker;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    // Починаючи з .NET 9 головне вікно створюється тут (властивість MainPage застаріла)
    protected override Window CreateWindow(IActivationState? activationState) =>
        new(new AppShell());
}
