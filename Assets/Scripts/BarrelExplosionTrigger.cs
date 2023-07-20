using UnityEngine;
using UnityEngine.EventSystems;

public class BarrelExplosionTrigger : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private float _explosionLifetime;

    private Explosion _explosion;

    public void OnPointerClick(PointerEventData eventData)
    {
        _explosion.transform.parent = null;
        _explosion.Explode();

        Destroy(_explosion.gameObject, _explosionLifetime);
        Destroy(gameObject);
    }

    private void Awake()
    {
        _explosion = GetComponentInChildren<Explosion>();
    }
}
