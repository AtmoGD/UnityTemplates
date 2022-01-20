using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private GameObject _testObject;
    [SerializeField] private Vector3 _testVector;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject obj = Instantiate(_testObject, _testVector, Quaternion.identity);
            Destroy(obj, 5f);
        }
    }
}
