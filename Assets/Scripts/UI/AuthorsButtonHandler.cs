using UnityEngine;

public class AuthorsButtonHandler : MonoBehaviour
{
    [SerializeField] private AuthorsPanelHandler _panel;

    public void ActivatePanel()
    {
        _panel.gameObject.SetActive(true);
    }
}
