using UnityEngine;
using System.ComponentModel;
using UnityWeld.Binding;

namespace TwoWayExample
{
    [Binding]
    public class MyViewModel2 : MonoBehaviour, INotifyPropertyChanged
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
}
