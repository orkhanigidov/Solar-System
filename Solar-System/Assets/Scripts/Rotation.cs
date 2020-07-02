using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.up, speed * Time.deltaTime);
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.Self);
    }
}
