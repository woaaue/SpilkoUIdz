using System.Collections.Generic;
using UnityEngine;

public class MaterialChanger : MonoBehaviour
{
    [SerializeField] private List<Renderer> _figures = new List<Renderer>();

    public void ChangeMaterial(Material material)
    {
        for (int i = 0; i < _figures.Count; i++)
        {
            _figures[i].material = material;
        }
    }
}
