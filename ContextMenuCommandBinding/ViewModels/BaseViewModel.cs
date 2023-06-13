using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ContextMenuCommandBinding.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        private TaskNotifier initTask;
        public Task InitTask
        {
            get => initTask;
            set => SetPropertyAndNotifyOnCompletion(ref initTask, value);
        }

        public virtual void Initialize()
        {

        }
    }
}
