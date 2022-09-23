using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    public MoveBehaviour movement;
    public int playerHealth = 30;
    [SerializeField] GameManager gameManager;

    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Enemy"){
            playerHealth -= 10;
            StartCoroutine(DelayedAction());
            Debug.Log("onColl ph: ");
            Debug.Log(playerHealth);
            if(playerHealth == 0){
                Debug.Log("in if ph: " + playerHealth);
                gameManager.EndGame();
            }
        }
    }

    private IEnumerator DelayedAction() {
        yield return new WaitForSeconds(5);
    }
}
