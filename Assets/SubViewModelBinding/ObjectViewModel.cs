using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityWeld.Binding;

[Binding]
public class ObjectViewModel : MonoBehaviour
{
    /// <summary>
    /// The object we want to manipulate.
    /// </summary>
    public MeshRenderer obj;

    private ColorViewModel colorViewModel;

    /// <summary>
    /// Sub-view model for controlling the color of the object.
    /// </summary>
    [Binding]
    public ColorViewModel SubViewModel
    {
        get
        {
            // Lazily initialize the color view model.
            if (colorViewModel == null)
            {
                colorViewModel = new ColorViewModel(obj);
            }

            return colorViewModel;
        }
    }

    /// <summary>
    /// Property for controlling the object's rotation about the Y axis.
    /// </summary>
    [Binding]
    public float Rotation
    {
        get
        {
            return obj.transform.localRotation.eulerAngles.y;
        }
        set
        {
            obj.transform.localRotation = Quaternion.AngleAxis(value, Vector3.up);
        }
    }

    private void Awake()
    {
        Assert.IsNotNull(obj);
    }
}
