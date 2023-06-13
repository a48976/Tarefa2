using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turSpeed;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
       transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turSpeed );

    }
}
