using UnityEngine;
using System;

public class RagdollControl : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _rigidbodies;

    private void Start()
    {
        enabled = false;
    }

    private void OnEnable()
    {
        Array.ForEach(_rigidbodies, rigidbody => rigidbody.isKinematic = false);
    }

    private void OnDisable()
    {
        Array.ForEach(_rigidbodies, rigidbody => rigidbody.isKinematic = true);
    }
}
