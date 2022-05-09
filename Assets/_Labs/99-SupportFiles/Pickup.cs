using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Player"){
            m_MyAudioSource.Play();
            print("hit");
            m_MyAudioSource.Play();
            Destroy(gameObject);
        }
    }
}
