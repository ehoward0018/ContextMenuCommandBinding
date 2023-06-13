using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContextMenuCommandBinding.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace ContextMenuCommandBinding.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    public HomePageViewModel()
    {
        
    }

    [ObservableProperty] string exampleText = "CLICK SOMETHING!";

    [ObservableProperty]
    ObservableCollection<ExampleBox> exampleBoxes = new ObservableCollection<ExampleBox>()
    {
        new ExampleBox(){ BoxName = "YELLOW"},
        new ExampleBox(){ BoxName = "BLUE"},
        new ExampleBox(){ BoxName = "ORANGE"},
        new ExampleBox(){ BoxName = "PINK"}
    };

    [RelayCommand]
    void ExampleBoxClicked(ExampleBox box)
    {
        ExampleText = $"YOU CLICKED BOX: -{box.BoxName}- FROM HomePageViewModel";
    }
}
