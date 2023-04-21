using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGravity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigidBody;
    
    [SerializeField] public Vector3 gravity = new Vector3(0.0f, 9.81f, 0.0f);
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        rigidBody.AddForce( -  gravity * rigidBody.mass);
    }
}
