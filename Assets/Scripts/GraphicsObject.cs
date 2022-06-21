using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Graphics Object", menuName = "New Graphics Object")]
public class GraphicsObject : ScriptableObject
{
    public bool shouldUsePostProcess;
    public bool shouldUseShadows;
}
