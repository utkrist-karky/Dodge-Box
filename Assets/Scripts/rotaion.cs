using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaion : MonoBehaviour
{
    [SerializeField] float Xval = 0f; 
    [SerializeField] float Yval = 0f; 
    [SerializeField] float Zval = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xval,Yval,Zval); 
    }
}
