using UnityEngine;
using UnityEngine.EventSystems;

public class FirecampToggler : MonoBehaviour, IPointerClickHandler
{
    private AudioSource _audio;
    private ParticleSystem[] _particles;

    private bool _enabled = true;

    public void OnPointerClick(PointerEventData eventData)
    {
        _enabled = _enabled ? false : true;

        if (_enabled)
            _audio.Play();
        else
            _audio.Stop();

        foreach (ParticleSystem particle in _particles)
        {
            if (_enabled)
                particle.Play();
            else
                particle.Stop();
        }
    }

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _particles = GetComponentsInChildren<ParticleSystem>();
    }

}
