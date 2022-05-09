using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancescore : MonoBehaviour
{    
    //Score
    float score = 0; 
    float distanceScore  = 0; 
    // Checking distance
    Vector3 previousPosition; 
    float calculatedDistance;
    
    void Awake()
    {
    previousPosition = transform.position;
    }

    void Update()
    {
    calculatedDistance += (transform.position - previousPosition).magnitude;
    previousPosition = transform.position;
    distanceScore = Mathf.Round(calculatedDistance/10);   
    score = distanceScore;
    GameObject.Find("score").GetComponent<UnityEngine.UI.Text>().text= "Score :"+ score.ToString();
    }
}
