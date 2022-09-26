using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    
    public int playerHealth;
    [SerializeField] GameManager gameManager;

    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Enemy"){
            playerHealth -= 10;
            if(playerHealth == 0){
                gameManager.EndGame(false);
            }
        }
    }
}
