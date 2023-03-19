using UnityEngine;

public class Interaction : MonoBehaviour
{
    private void Update()
    {
        Ray _mousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_mousePosition, out RaycastHit hit))
            if (hit.collider.TryGetComponent(out Clicakble clicakble))
                if (Input.GetMouseButtonDown(0))
                    clicakble.Hit();
    }
}
