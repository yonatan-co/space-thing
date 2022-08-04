using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    [SerializeField] ParticleSystem _particleSystem;
    [SerializeField] int force;
    [SerializeField] ParticleSystem _explosion;
    Transform _expHolder;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        _particleSystem.Play();
        _expHolder = GameObject.Find("ExpHolder").GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        var explosion = Instantiate(_explosion, transform.position, Quaternion.identity, _expHolder);
        explosion.Play();
        Destroy(gameObject);
    }
}
