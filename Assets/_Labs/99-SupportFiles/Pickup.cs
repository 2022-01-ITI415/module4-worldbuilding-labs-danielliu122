using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void onTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            print("hit");
            Destroy(gameObject);
        }
    }
}
