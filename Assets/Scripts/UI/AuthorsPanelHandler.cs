using System;
using UnityEngine;
using UnityEngine.UI;

public class AuthorsPanelHandler : MonoBehaviour
{
    [SerializeField] private VerticalLayoutGroup _buttonsLayout;
    [SerializeField] private AuthorsExitText _exitText;
    [SerializeField] private KeyCode _exitKey;

    private Button[] _buttons;

    private void Awake()
    {
        _buttons = _buttonsLayout.GetComponentsInChildren<Button>();
        _exitText.SetButtonName(_exitKey.ToString());
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        Array.ForEach(_buttons, button => button.gameObject.SetActive(false));
    }
    private void OnDisable()
    {
        Array.ForEach(_buttons, button => button.gameObject.SetActive(true));
    }

    private void Update()
    {
        if (enabled &&
            Input.GetKeyUp(_exitKey))
        {
            gameObject.SetActive(false);

            Array.ForEach(_buttons, button => button.gameObject.SetActive(true));
        }
    }
}
