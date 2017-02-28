using UnityEngine;
using System.ComponentModel;
using UnityWeld.Binding;

[Binding]
public class MyViewModel1 : MonoBehaviour, INotifyPropertyChanged
{
    private float timer = 0;

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

    /// <summary>
    /// Event to raise when a property's value has changed.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    // Use this for initialization
    void Start()
    {
        SetRandomText();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            SetRandomText();
            timer = 0f;
        }        
    }

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public void SetRandomText()
    {
        Text = Random.Range(0f, 10000f).ToString();
    }
}
