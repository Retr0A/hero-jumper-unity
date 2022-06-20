using System.Collections;
using UnityEngine;

public class LandGenerator : MonoBehaviour
{
    [Header("Style")]
    public Gradient color;
    public GameObject tile;
    public GameObject[] entities;

    [Header("Noise")]
    public float noiseScale;
    [Range(0, 1)]
    public float fillPercent;
    public int size;
    public int landHeight;

    private void Start()
    {
        StartCoroutine(GenerateTerrain());
    }

    public IEnumerator GenerateTerrain()
    {
        for (int x = 0; x <= size; x++)
        {
            for (int y = 0; y <= size; y++)
            {
                float a = Mathf.PerlinNoise((float)x / noiseScale, (float)y / noiseScale);
                float h = a > 1 - (float)fillPercent ? 0 : -0.1f;
                GameObject g = Instantiate(tile, new Vector3(x, h, y), Quaternion.identity);
                g.GetComponent<MeshRenderer>().material.color = a > 1 - (float)fillPercent ? color.Evaluate(a + 0.3f) : color.Evaluate(a);
                g.transform.parent = transform;
                g.transform.localScale = a > 1 - (float)fillPercent ? new Vector3(1, a * landHeight, 1) : new Vector3(1, UnityEngine.Random.Range(0.2f, 0.7f), 1);

                if (Utils.RandomBoolean())
                {
                    GameObject l = UnityEngine.Random.value > 0.9f && a > 1 - (float)fillPercent ?
                        Instantiate(entities[UnityEngine.Random.Range(0, entities.Length)], new Vector3(x, h * 10f, y), Quaternion.Euler(-90, UnityEngine.Random.Range(0, 360), 0)) : null;
                }

            }
            yield return new WaitForSeconds(0.000000001f);
        }
    }
}