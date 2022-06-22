using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Header("Layers")]
    public LayerMask defaultLayer;
    public LayerMask groundLayer;

    [Header("Style")]
    public Color defaultColor;

    [HideInInspector]
    public bool isGround { get; set; }
    [HideInInspector]
    public TileType type { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = gameObject.GetComponent<MeshRenderer>().material.color;

        if (isGround)
        {
            gameObject.layer = groundLayer;
        }
        else
        {
            gameObject.layer = defaultLayer;
        }
    }

    private void OnMouseOver()
    {
        if (type == TileType.Ground)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = defaultColor - new Color(0.2f, 0.2f, 0.2f, 1.0f);
        }
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = defaultColor;
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