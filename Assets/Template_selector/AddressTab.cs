using UnityWeld.Binding;

namespace TemplateExample
{
    [Binding]
    public class AddressTab: Tab {

        [Binding]
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (number == value)
                {
                    return;
                }

                number = value;

                OnPropertyChanged("Number");
            }
        }
        private string number = string.Empty;

        [Binding]
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (street == value)
                {
                    return;
                }

                street = value;

                OnPropertyChanged("Street");
            }
        }
        private string street = string.Empty;

        [Binding]
        public string Suburb
        {
            get
            {
                return suburb;
            }
            set
            {
                if (suburb == value)
                {
                    return;
                }

                suburb = value;

                OnPropertyChanged("Suburb");
            }
        }
        private string suburb = string.Empty;
    }
}
