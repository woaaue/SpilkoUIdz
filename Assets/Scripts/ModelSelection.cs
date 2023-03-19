using System.Collections.Generic;
using UnityEngine;

public class ModelSelection : MonoBehaviour
{
    [SerializeField] private List<GameObject> _selectedObjects = new List<GameObject>();

    public void ChooseObjects(int number)
    {
        for (int i = 0; i < _selectedObjects.Count; i++)
        {
            if (i == number)
                _selectedObjects[i].gameObject.SetActive(true);
            else
                _selectedObjects[i].gameObject.SetActive(false);
        }
    }
}
