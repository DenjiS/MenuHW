using UnityEngine;
using UnityEngine.EventSystems;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private float _pushForce;
    [SerializeField] private float _verticalForceReduction;

    private ParticleSystem[] _particles;
    private AudioSource _audio;

    public void Explode()
    {
        foreach (ParticleSystem particle in _particles)
        {
            particle.transform.parent = null;
            particle.Play();
        }

        _audio.Play();

        RaycastHit[] hits = Physics.SphereCastAll(transform.position, _radius, transform.forward);

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.TryGetComponent(out RagdollControl ragdoll))
                PushRagdollOut(ragdoll);
        }
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (_verticalForceReduction == 0)
            _verticalForceReduction++;
    }
#endif

    private void Awake()
    {
        _particles = GetComponentsInChildren<ParticleSystem>();
        _audio = GetComponent<AudioSource>();
    }

    private void PushRagdollOut(RagdollControl ragdoll)
    {
        ragdoll.enabled = true;

        foreach (Rigidbody rigidbody in ragdoll.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 distanceVector = (rigidbody.transform.position - transform.position);
            Vector3 forceDirection = new(
                _pushForce / distanceVector.x,
                _pushForce / (distanceVector.y * _verticalForceReduction),
                _pushForce / distanceVector.z);

            rigidbody.AddForce(forceDirection, ForceMode.Impulse);
        }
    }
}
