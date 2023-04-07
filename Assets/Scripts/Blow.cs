using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blow : MonoBehaviour
{
    public float Radius = 1;
    public float Power = 1;

    private float _currentPower;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _currentPower = Power;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _currentPower = 0;
        }
    }

    void FixedUpdate()
    {
        Boom();
    }

    void Boom()
    {
        if (_currentPower == 0)
        {
            return;
        }

        var bodies = FindObjectsOfType<Rigidbody>();

        foreach (var obj in bodies)
        {
            var objDirection = obj.transform.position - transform.position;

            if (objDirection.magnitude < Radius) {
                obj.AddForce(objDirection.normalized * _currentPower * (Radius - objDirection.magnitude), ForceMode.Impulse);
            }
        }

        GetComponentInChildren<ParticleSystem>().Play();
    }
}
