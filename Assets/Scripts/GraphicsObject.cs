using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Graphics Object", menuName = "Graphics Object")]
public class GraphicsObject : ScriptableObject
{
    [Header("Effects")]
    public bool shouldUsePostProcess;
    [Header("Shadows")]
    public bool shouldUseShadows;
}
