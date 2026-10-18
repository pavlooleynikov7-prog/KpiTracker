using KpiTracker.ViewModels;

namespace KpiTracker.Views;

public partial class MainPage : ContentPage
{
    // ViewModel надходить із контейнера DI (див. MauiProgram.cs)
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
