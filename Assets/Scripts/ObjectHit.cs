using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] bool makeRed = false; 
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Player"){
            if(makeRed){
                GetComponent<MeshRenderer>().material.color = Color.red;
            }
            gameObject.tag = "Hit";
        }
  
    }
}
 