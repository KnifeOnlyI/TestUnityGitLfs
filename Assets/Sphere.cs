using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Color color;

    private void Awake()
    {
        GetComponent<MeshRenderer>().material.color = color;
    }
}
