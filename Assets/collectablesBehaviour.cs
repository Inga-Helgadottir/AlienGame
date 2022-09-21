using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectablesBehaviour : MonoBehaviour{

    [SerializeField] GameManager gameManager;
    public GameObject collectable;

    //gets called b4 start
    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Destroy(collectable);
            gameManager.UpdateScore(1);
        }
    }
}
