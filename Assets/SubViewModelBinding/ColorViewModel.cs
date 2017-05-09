using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityWeld.Binding;

/// <summary>
/// View model for controlling the color of a mesh.
/// </summary>
[Binding]
public class ColorViewModel
{
    private Material mat;

    public ColorViewModel(MeshRenderer mesh)
    {
        mat = mesh.material;
    }

    /// <summary>
    /// The red component of the mesh's color.
    /// </summary>
    [Binding]
    public float Red
    {
        get
        {
            return mat.color.r;
        }
        set
        {
            var color = mat.color;
            color.r = value;
            mat.color = color;
        }
    }

    /// <summary>
    /// The green component of the mesh's color.
    /// </summary>
    [Binding]
    public float Green
    {
        get
        {
            return mat.color.g;
        }
        set
        {
            var color = mat.color;
            color.g = value;
            mat.color = color;
        }
    }

    /// <summary>
    /// The blue component of the mesh's color.
    /// </summary>
    [Binding]
    public float Blue
    {
        get
        {
            return mat.color.b;
        }
        set
        {
            var color = mat.color;
            color.b = value;
            mat.color = color;
        }
    }
}
