using UnityEngine;

public class PointerLighting : MonoBehaviour
{
    private Camera _camera;
    private Light _light;

    private void Awake()
    {
        _camera = Camera.main;
        _light = GetComponentInChildren<Light>();
    }

    private void Start()
    {
        _light.enabled = false;
    }

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray castPoint = _camera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(castPoint, out RaycastHit hit))
        {
            if (_light.enabled == false)
                _light.enabled = true;

            _light.transform.position = hit.point;
        }
        else
        {
            _light.enabled = false;
        }
    }
}
