using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityWeld.Binding;

namespace Assets._5_Validation
{
    [CreateAssetMenu(menuName = "Unity Weld/Adapter options/Color validation adapter")]
    public class ColorValidationAdapterOptions : AdapterOptions
    {
        [Header("Valid color")]
        public ColorBlock NormalColor;

        [Space]

        [Header("Invalid color")]
        public ColorBlock InvalidColor;
    }
}
