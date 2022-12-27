using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class HealthHelperBehaviour : MonoBehaviour{

    [SerializeField] GameManager gameManager;
    public GameObject healthHelper;
    public System.Random ran = new System.Random();

    void Start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other){
        int xMin = 777;
        int xMax = 1715;
        
        int zMin = 105;
        int zMax = 1475;

        int x = ran.Next(xMin, xMax); 
        int z = ran.Next(zMin, zMax); 

        if(other.tag == "Player"){
            transform.position = new Vector3((float)x, 1.6f, (float)z);
        }
    }
}
