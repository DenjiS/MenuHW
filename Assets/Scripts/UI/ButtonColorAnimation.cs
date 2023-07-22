using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonColorAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _changeDuration;

    private Image _image;
    private Color _initialColor;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.CrossFadeColor(_targetColor, _changeDuration, true, true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.CrossFadeColor(_initialColor, _changeDuration, true, true);
    }

    private void Awake()
    {
        _image = GetComponent<Button>().image;
        _initialColor = _image.color;
    }

    private void OnEnable()
    {
        _image.CrossFadeColor(_initialColor, _changeDuration, true, true);
    }
}
