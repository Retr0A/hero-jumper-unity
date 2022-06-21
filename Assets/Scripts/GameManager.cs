using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Graphics Settings")]
    public GraphicsObject graphicsObject;
    public GameObject postProcessObject;

    // Start is called before the first frame update
    void Start()
    {
        postProcessObject.SetActive(graphicsObject.shouldUsePostProcess);
        QualitySettings.shadows = graphicsObject.shouldUseShadows ? ShadowQuality.All : ShadowQuality.Disable;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
