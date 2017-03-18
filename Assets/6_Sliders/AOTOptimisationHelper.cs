using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityWeld.Binding.Internal;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable

#pragma warning disable 219 // Disable warning that variable is never used

/// <summary>
/// In order for certain generic types to not be optimised-out by IL2CPP for
/// platforms like Xbox One, iPhone and WebGL, we need to reference them at 
/// least once in code instead of just calling them via reflection. 
/// 
/// See this page for more details:
/// https://docs.unity3d.com/Manual/TroubleShootingIPhone.html 
/// In the section "The game crashes with the error message “ExecutionEngineException: 
/// Attempting to JIT compile method ‘SometType`1&lt;SomeValueType&gt;:.ctor ()’ while 
/// running with –aot-only.”"
/// </summary>
internal class AOTOptimisationHelper
{
    // Even though this method is never called, the fact that it exists will
    // ensure the compiler includes the types referenced in it so that we can
    // later refer to those via reflection.
    private void EnsureGenericTypes()
    {
        var strEventBinder = new UnityEventBinder<string>(null, null);
        var floatEventBinder = new UnityEventBinder<float>(null, null);
    }
}

#pragma warning restore 219