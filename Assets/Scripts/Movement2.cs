using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    //    [SerializeField] Transform target;
    //    [SerializeField] Rigidbody rb;
    //    [SerializeField] float t;
    //    [SerializeField] float force;
    [SerializeField] Vector3 MoveDirect;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        //Vector3 f = target.position - transform.position;
        //f = f.normalized;
        //f = f * force;
        //rb.AddForce(f);
        transform.Translate(MoveDirect,Space.World);
    }
}
