using UnityWeld.Binding;

/// <summary>
/// View-model for items displayed in the collection.
/// </summary>
[Binding]
public class ItemViewModel
{
    [Binding]
    public string DisplayText
    {
        get;
        private set;
    }

    public ItemViewModel(string displayText)
    {
        this.DisplayText = displayText;
    }
}

