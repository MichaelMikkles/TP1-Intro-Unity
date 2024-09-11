using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotateCube : MonoBehaviour
{
    private Vector3 rotation = new Vector3(0, 3, 0);
    public float speed = 3.0f;
    public  InputAction activateRotation;
    public bool isRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        activateRotation.Enable();
    }
    // Update is called once per frame
    void Update()
    {
        activateRotation.Enable();
        activateRotation.performed += ctx => Debug.Log("Rotation changed");
        if (activateRotation.triggered)
        {
            isRotating = !isRotating;
        }
        if (isRotating){
            transform.Rotate(rotation * speed * Time.deltaTime);
        }
        
    }
}
