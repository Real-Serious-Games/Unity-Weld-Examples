using UnityWeld.Binding;

[Binding]
public class NameTab: Tab {

    [Binding]
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            if (firstName == value)
            {
                return;
            }

            firstName = value;

            OnPropertyChanged("FirstName");
        }
    }
    private string firstName = string.Empty;

    [Binding]
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            if (lastName == value)
            {
                return;
            }

            lastName = value;

            OnPropertyChanged("LastName");
        }
    }
    private string lastName = string.Empty;
}
