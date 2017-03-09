using Assets._5_Validation;
using UnityEngine;
using UnityEngine.UI;
using UnityWeld.Binding;

namespace ValidationExample
{
    [Adapter(typeof(bool), typeof(ColorBlock), typeof(ColorValidationAdapterOptions))]
    public class ColorValidationAdapter : IAdapter
    {
        public object Convert(object valueIn, AdapterOptions adapterOptions)
        {
            var isValid = (bool)valueIn;
            var options = (ColorValidationAdapterOptions) adapterOptions;

            return isValid ? options.NormalColor : options.InvalidColor;
        }
    }
}
