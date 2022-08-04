using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float t;
    [SerializeField] float speed;
    [SerializeField] Transform LeftBorder;
    [SerializeField] Transform RightBorder;


    void Start()
    {

    }

    private void FixedUpdate()
    {
        Vector3 A = transform.position;
        Vector3 B = target.transform.position;
        transform.position = new Vector3(
            Mathf.Clamp(
                Vector3.Lerp(A, B, t).x,
                LeftBorder.position.x,
                RightBorder.position.x
                ),
                transform.position.y,
                transform.position.z
                );


    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if (h != 0)
        {
            target.transform.position = new Vector3(
                target.transform.position.x + (h * speed),
                target.transform.position.y,
                target.transform.position.z);
        }

        float v = Input.GetAxis("Vertical");
        if (v != 0)
        {
            target.transform.position = new Vector3(
                target.transform.position.x,
                target.transform.position.y,
                target.transform.position.z + (v * speed));

        }

    }
}
