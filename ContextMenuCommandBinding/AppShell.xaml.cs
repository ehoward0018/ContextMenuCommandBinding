using ContextMenuCommandBinding.ViewModels;

namespace ContextMenuCommandBinding;

public partial class AppShell : Shell
{ 
	public AppShell(AppShellViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
