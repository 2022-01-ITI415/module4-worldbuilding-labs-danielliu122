using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EthanPickup : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    bool ethanMoved = false;
    bool gameEnd= false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().enabled= false;
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            print("hit player");
            m_MyAudioSource.Play();
        
            float x= 917;
            float y=1;
            float z= 466;
            transform.position = new Vector3(x,y,z);
            ethanMoved = true;
        }
    }
    void Update(){
        if (ethanMoved && GameObject.FindGameObjectsWithTag("pickup").Length == 1){
            GameObject.Find("gui").GetComponent<UnityEngine.UI.Text>().text= "You Win! ";
            GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().enabled= true;
            gameEnd=true;
        }
    }
}
