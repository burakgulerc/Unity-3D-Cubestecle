using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float yRotateAngle = 45;
    [SerializeField] float yRotateSpeed = 2;

    void Start()
    {
        
    }

    
    void Update()
    {
        float yRot = yRotateAngle * yRotateSpeed * Time.deltaTime;
        transform.Rotate(0, yRot, 0);
    }
}
