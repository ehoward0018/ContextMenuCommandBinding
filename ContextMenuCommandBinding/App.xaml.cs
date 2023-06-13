using ContextMenuCommandBinding.ViewModels;

namespace ContextMenuCommandBinding;

public partial class App : Application
{
	public App(AppShellViewModel vm)
	{
		InitializeComponent();

		MainPage = new AppShell(vm);
	}
}
