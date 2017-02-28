using UnityEngine;
using System.ComponentModel;
using UnityWeld.Binding;

[Binding]
public class MyViewModel7 : MonoBehaviour, INotifyPropertyChanged
{
    private string[] options = new string[]
    {
        "Option-A",
        "Option-B",
        "Option-C"
    };

    private string selectedItem = "Option-B";

    [Binding]
    public string SelectedItem
    {
        get
        {
            return selectedItem;
        }
        set
        {
            if (selectedItem == value)
            {
                return; // No change.
            }

            selectedItem = value;

            OnPropertyChanged("SelectedItem");
        }
    }

    public string[] Options
    {
        get
        {
            return options;
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
