using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Audio;

public class PlayerCollision : MonoBehaviour{
    
    public int playerHealth;
    public AudioSource alienCrashSound;
    [SerializeField] GameManager gameManager;

    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Enemy"){
            playerHealth -= 10;
            alienCrashSound.Play();
            if(playerHealth == 0){
                gameManager.EndGame(false);
            }
        }
    }
}
