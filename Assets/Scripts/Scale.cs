using UnityEngine;

public class Scale : MonoBehaviour
{
    public void Resize(float value)
    {
        transform.localScale = Vector3.one * value;
    }
}
