using TMPro;
using UnityEngine;

public class AuthorsExitText : MonoBehaviour
{
    private readonly string _description = " - exit from panel";

    private TextMeshProUGUI _text;
    private string _buttonName;

    public void SetButtonName(string name) =>
        _buttonName = name;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _text.text = _buttonName + _description;
    }
}
