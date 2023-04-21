using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 currentEulerAngles;
    private float roationSpeed = 25.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * roationSpeed);
    }
}
