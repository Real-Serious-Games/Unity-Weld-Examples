using UnityEngine;
using System;
using System.ComponentModel;
using UnityWeld.Binding;

[Binding]
public class MyViewModel4 : MonoBehaviour, INotifyPropertyChanged
{
    private float cubeRotation = 0f;

    private string text = "0";

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

            try
            {
                cubeRotation = float.Parse(text);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }

            OnPropertyChanged("Text");
        }
    }

    /// <summary>
    /// Event to raise when a property's value has changed.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    [Binding]
    public void RotateCube()
    {
        cubeRotation = cubeRotation + 10f;
        text = cubeRotation.ToString();

        OnPropertyChanged("Text");
    }

    void Update()
    {
        var cube = GameObject.Find("Cube");
        cube.transform.localEulerAngles = new Vector3(0f, cubeRotation, 0f);
    }

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
