using CommunityToolkit.Mvvm.Input;
using ContextMenuCommandBinding.Models;
using System.Diagnostics;

namespace ContextMenuCommandBinding.ViewModels;

public partial class AppShellViewModel : BaseViewModel
{
    readonly HomePageViewModel viewModel;
    
    public AppShellViewModel(HomePageViewModel vm)
    {
        viewModel = vm;
    }

    [RelayCommand]
    void ExampleBoxClicked(ExampleBox box)
    {
        viewModel.ExampleText = $"YOU CLICKED BOX: -{box.BoxName}- FROM AppShellViewModel";
    }
}
