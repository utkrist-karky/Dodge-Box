using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFall : MonoBehaviour
{
    MeshRenderer renderer; 
    Rigidbody rigidBody; 
    [SerializeField] float timeToWait = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        renderer = GetComponent<MeshRenderer>(); 
        renderer.enabled = false; 
        rigidBody.useGravity = false; 
    }

    // Update is called once per frame
    
    void Update()
    {
        if(Time.time > timeToWait){
            renderer.enabled = true; 
            rigidBody.useGravity = true; 
            // GetComponent<MeshRenderer>().material.color = Color.red;
            // GetComponent<Rigidbody>().mass = 1; 
        }
    }
}
