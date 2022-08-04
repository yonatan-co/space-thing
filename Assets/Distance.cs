using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] Collider terr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = 5.0f;
        //Debug.Log(terr.ClosestPoint(transform.position));
        //transform.position = new Vector3(transform.position.x, (transform.position.y - terr.ClosestPoint(transform.position).y) + 5, transform.position.z);
        transform.position = (transform.position - terr.ClosestPoint(transform.position)).normalized * distance + terr.ClosestPoint(transform.position);

    }
}
