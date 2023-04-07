using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SupermanPrefab;

    private GameObject _currentSuperman;
    void Start()
    {
        _currentSuperman = Instantiate(SupermanPrefab);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var prevSuperman = _currentSuperman;
            _currentSuperman.GetComponent<Superman>().Fly();
            Destroy(_currentSuperman, 2.0f);

            _currentSuperman = Instantiate(SupermanPrefab);
            var pos = _currentSuperman.transform.position;
            pos.x = prevSuperman.transform.position.x;

            _currentSuperman.transform.position = pos;
            
        }
    }
}
