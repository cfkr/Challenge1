using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerRotate : MonoBehaviour
{
    private float speed = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
