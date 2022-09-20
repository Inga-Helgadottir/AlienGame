using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    public MoveBehaviour movement;
    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Enemy"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
