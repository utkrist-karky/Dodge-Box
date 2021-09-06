using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer(){
        float speed = 10;
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*speed;
        transform.Translate(xValue,0,zValue);
        // Debug.Log(Time.time);
    }
}
