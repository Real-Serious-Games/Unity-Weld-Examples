using UnityEngine;
using System.ComponentModel;
using UnityWeld.Binding;

[Binding]
public class MyUI3 : MonoBehaviour, INotifyPropertyChanged
{
    private ObservableList<ItemViewModel> items = new ObservableList<ItemViewModel>()
    {
        new ItemViewModel("1"),
        new ItemViewModel("2"),
        new ItemViewModel("3")
    };

    [Binding]
    public ObservableList<ItemViewModel> Items
    {
        get
        {
            return items;
        }
    }


    /// <summary>
    /// Event to raise when a property's value has changed.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
