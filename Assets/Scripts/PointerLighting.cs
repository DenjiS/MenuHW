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

    private void Update()
    {
    //    Vector2 mousePosition = Input.mousePosition;
    //    Vector3 lightPosition = Input.mousePosition;
    //    _light.transform.position = _camera.ScreenToWorldPoint(lightPosition);
    //    Debug.Log(lightPosition + "||" + _camera.ScreenToWorldPoint(lightPosition));
    }
}
