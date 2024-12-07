using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Squawker.Services;
using System.Windows.Input;

namespace Squawker;

public partial class MainWindowViewModel : ObservableObject
{
    public ICommand GenerateSquawkCommand { get; private set; }


    [ObservableProperty]
    private string squawk = string.Empty;


    private readonly IvaoApiService _apiService;

    public MainWindowViewModel(IvaoApiService apiService)
    {
        _apiService = apiService;

        GenerateSquawkCommand = new RelayCommand(GenerateSquawk);
    }

    private async void GenerateSquawk()
    {
        // Generate Squawk based on current ivao data.

        Squawk = _apiService.GetNewSquawk();
    }
}
