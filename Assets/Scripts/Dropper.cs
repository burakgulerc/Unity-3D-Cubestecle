using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer meshRenderer;
    Rigidbody rBody;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rBody.useGravity = false;
    }


    void Update()
    {
        if(Time.time > timeToWait)
        {
           meshRenderer.enabled = true;
            rBody.useGravity = true;
        }
    }
}
