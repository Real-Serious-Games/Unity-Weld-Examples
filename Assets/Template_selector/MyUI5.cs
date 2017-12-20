using UnityEngine;
using System.ComponentModel;
using TemplateExample;
using UnityWeld.Binding;

[Binding]
public class MyUI5 : MonoBehaviour, INotifyPropertyChanged {

    [Binding]
    public NameTab NameTab
    {
        get
        {
            return nameTab;
        }
    }
    private NameTab nameTab = new NameTab();

    [Binding]
    public AddressTab AddressTab
    {
        get
        {
            return addressTab;
        }
    }
    private AddressTab addressTab = new AddressTab();
    
    [Binding]
    public Tab ActiveTab
    {
        get
        {
            // Lazy init
            if (activeTab == null)
            {
                activeTab = NameTab;
            }

            return activeTab;
        }
        set
        {
            if (activeTab == value)
            {
                return;
            }

            activeTab = value;

            OnPropertyChanged("ActiveTab");
        }
    }
    private Tab activeTab = null;

    [Binding]
    public void ActivateNameTab()
    {
        ActiveTab = nameTab;
    }

    [Binding]
    public void ActivateAddressTab()
    {
        ActiveTab = addressTab;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
