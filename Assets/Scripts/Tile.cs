using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Layers")]
    public LayerMask defaultLayer;
    public LayerMask groundLayer;

    [HideInInspector]
    public bool isGround { get; set; }
    [HideInInspector]
    public TileType type { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        if (isGround)
        {
            gameObject.layer = groundLayer;
        }
        else
        {
            gameObject.layer = defaultLayer;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum TileType
{
    Ground,
    Water
}