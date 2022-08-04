using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject B;
    [SerializeField] GameObject B_collector;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var B_postion = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y - 2,
                gameObject.transform.position.z
                );
            Instantiate(B, B_postion, Quaternion.identity, B_collector.transform );
        }
    }
}
