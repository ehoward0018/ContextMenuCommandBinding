using ContextMenuCommandBinding.Models;

namespace ContextMenuCommandBinding.Templates.Selectors;

public class ContextMenuCommandBindingSelector : DataTemplateSelector
{
    public DataTemplate YellowTemplate { get; set; }
    public DataTemplate OtherTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        ExampleBox box = (ExampleBox)item;

        if (box.BoxName == "YELLOW")
            return YellowTemplate;
        return OtherTemplate;
    }
}
