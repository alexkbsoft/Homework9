using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntigravSphere : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = false;
    }
   
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = true;
    }

    void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>().useGravity = false;
    }
}
