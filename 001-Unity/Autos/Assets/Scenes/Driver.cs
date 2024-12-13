using System.Collections;
using System.Collections.Generic;
using System.Net.WebSockets;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    float steerSpeed = 0.1f;
    float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,steerSpeed);
        transform.Rotate(0,moveSpeed,0);
    }
}
