using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Superman : MonoBehaviour
{
    public float HitPower = 10.0f;
    private Rigidbody _rb;
    private bool _isFlying = false;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Fly() {
        _isFlying = true;
        _rb.velocity = transform.forward * 10.0f;
    }

    void FixedUpdate()
    {
        if (_isFlying) {
            return;
        }

        var right = Input.GetAxis("Horizontal");

        transform.Translate(right * Vector3.right * 5.0f * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Coll - " + other.gameObject.name);
        if (other.gameObject.tag == "BadGuy")
        {
            other.rigidbody.AddForce((other.rigidbody.transform.position - transform.position).normalized * HitPower, ForceMode.Impulse);
            other.rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
