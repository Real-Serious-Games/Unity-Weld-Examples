using UnityEngine;
using System.Collections;
using UnityUI.Binding;
using System.ComponentModel;

[Binding]
public class MyUI : MonoBehaviour, INotifyPropertyChanged
{
    private string text = "<Type some text>";

    [Binding]
    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            if (text == value)
            {
                return; // No change.
            }

            text = value;

            OnPropertyChanged("Text");
        }
    }

    private bool randomizerEnabled = false;

    [Binding]
    public bool RandomizerEnabled
    {
        get
        {
            return randomizerEnabled;
        }
        set
        {
            if (randomizerEnabled == value)
            {
                return; // No change.
            }

            randomizerEnabled = value;

            OnPropertyChanged("RandomizerEnabled");
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
        if (RandomizerEnabled)
        {
            SetRandomText();
        }
    }

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Binding]
    public void SetRandomText()
    {
        Text = Random.Range(0f, 10000f).ToString();
    }



}
