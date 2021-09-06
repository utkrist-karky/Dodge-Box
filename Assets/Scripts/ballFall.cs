using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time == 3){
            // GetComponent<MeshRenderer>().material.color = Color.red;
            GetComponent<Rigidbody>().mass = 1; 
        }
    }
}
