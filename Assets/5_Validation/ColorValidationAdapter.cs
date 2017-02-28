using UnityEngine;
using UnityEngine.UI;
using UnityWeld.Binding;

[Adapter(typeof(bool), typeof(ColorBlock))]
public class ColorValidationAdapter : IAdapter
{
    public object Convert(object valueIn)
    {
        var isValid = (bool)valueIn;
        if (isValid)
        {
            return new ColorBlock()
            {
                normalColor = Color.white,
                highlightedColor = Color.white,
                pressedColor = Color.white,
                disabledColor = Color.white,
                colorMultiplier = 1,
                fadeDuration = 0.1f,
            };
        }
        else
        {
            return new ColorBlock()
            {
                normalColor = Color.red,
                highlightedColor = Color.red,
                pressedColor = Color.red,
                disabledColor = Color.white,
                colorMultiplier = 1,
                fadeDuration = 0.1f,
            };
        }
    }
}
