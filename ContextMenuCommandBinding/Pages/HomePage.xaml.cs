using ContextMenuCommandBinding.Models;
using ContextMenuCommandBinding.ViewModels;
using System.Diagnostics;

namespace ContextMenuCommandBinding.Pages;

public partial class HomePage : ContentPage
{
	readonly HomePageViewModel viewModel;
	public HomePage(HomePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		viewModel = vm;
	}

	void ExampleBoxClicked(object sender, EventArgs e)
	{
		var menuItem = sender as MenuItem;
		ExampleBox box = (ExampleBox)menuItem.CommandParameter;

        viewModel.ExampleText = $"YOU CLICKED BOX: -{box.BoxName}- FROM HomePage.cs Click Event";
    }

    void ExampleBoxPressed(object sender, EventArgs e)
    {
        var menuItem = sender as Button;
        ExampleBox box = (ExampleBox)menuItem.CommandParameter;

        viewModel.ExampleText = $"YOU CLICKED BOX: -{box.BoxName}- FROM HomePage.cs Button Pressed Event";
    }
}