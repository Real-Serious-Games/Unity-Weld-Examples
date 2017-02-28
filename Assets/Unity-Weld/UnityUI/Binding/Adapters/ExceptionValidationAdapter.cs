using System;
using UnityWeld.Binding;

[Adapter(typeof(Exception), typeof(bool))]
public class ExceptionValidationAdapter : IAdapter
{
    public object Convert(object valueIn)
    {
        return (Exception)valueIn == null;
    }
}
