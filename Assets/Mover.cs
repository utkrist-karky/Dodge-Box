using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float xValue = 0; 
    [SerializeField]float yValue = 0;
    [SerializeField]float zValue = -0.21f; 


    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xValue,yValue,zValue);
    }
}
