using UnityEngine;
using System.ComponentModel;
using UnityWeld.Binding;

namespace ValidationExample
{
    [Binding]
    public class ValidationViewModel : MonoBehaviour, INotifyPropertyChanged
    {
        /// <summary>
        /// Value of the slider.
        /// </summary>
        private float sliderValue = 2.5f;

        /// <summary>
        /// Tracks when the text value is valid.
        /// </summary>
        private bool isValid = true;

        /// <summary>
        /// Cube that rotates based on the sliders
        /// </summary>
        private GameObject rotatingCube;

        /// <summary>
        /// Value of the slider.
        /// </summary>
        [Binding]
        public float SliderValue
        {
            get
            {
                return sliderValue;
            }
            set
            {
                if (sliderValue == value)
                {
                    return; // No change.
                }

                sliderValue = value;

                rotatingCube.transform.localEulerAngles = new Vector3(0f, sliderValue, 0f);

                OnPropertyChanged("SliderValue");
            }
        }

        /// <summary>
        /// Set to true whent the slider value input by the user is valid.
        /// </summary>
        [Binding]
        public bool IsValid
        {
            get
            {
                return isValid;
            }
            set
            {
                if (isValid == value)
                {
                    return;
                }

                isValid = value;

                OnPropertyChanged("IsValid");
            }
        }

        /// <summary>
        /// Event to raise when a property's value has changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Use this for initialization
        void Start()
        {
            rotatingCube = GameObject.Find("Cube");
            rotatingCube.transform.localEulerAngles = new Vector3(0f, sliderValue, 0f); //todo: Need a vector adaptor.
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
