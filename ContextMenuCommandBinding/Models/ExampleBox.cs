using CommunityToolkit.Mvvm.ComponentModel;

namespace ContextMenuCommandBinding.Models;

public partial class ExampleBox : ObservableObject
{
    [ObservableProperty] string boxName;
}
