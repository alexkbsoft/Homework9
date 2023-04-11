using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CueBall : MonoBehaviour
{
    
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 20.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
