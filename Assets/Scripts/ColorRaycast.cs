
using UnityEngine;

public class ColorRaycast : MonoBehaviour
{
    private RaycastObject _lastRaycastObject;
    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (_lastRaycastObject != null)
        {
            _lastRaycastObject.ResetColor();
        }
        
        if (Physics.Raycast(ray, out var hitInfo))
        {
            var raycastObject = hitInfo.collider.gameObject.GetComponent<RaycastObject>();

            if (raycastObject != null)
            {
                raycastObject.ChageColor();
                _lastRaycastObject = raycastObject;
            }
        }
    }
}
