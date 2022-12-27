using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Audio;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class PlayerCollision : MonoBehaviour{
    
    public int playerHealth;
    public TextMeshProUGUI healthText;
    public AudioSource alienCrashSound;
    [SerializeField] GameManager gameManager;
    public CameraShake cameraShake;
    public System.Random ran = new System.Random();
    public GameObject healthHelper;

    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        healthText.text = "Health: " + 30;
    }
    
    void OnTriggerEnter(Collider collider){
        if(collider.tag == "Enemy"){
            updateHealth("down");
            alienCrashSound.Play();
            StartCoroutine(cameraShake.Shake(.1f, .1f));
            if(playerHealth == 0){
                gameManager.EndGame(false);
            }
        }else if(collider.tag == "HealthHelper"){
            handleHealthHelperCollision();
        }
    }

    public void updateHealth(string upOrDown){
        if(upOrDown == "down"){
            playerHealth -= 10;
        }else{
            playerHealth += 10;
        }
        healthText.text = "Health: " + playerHealth;
    }

    public void handleHealthHelperCollision(){
        int xMin = 777;
        int xMax = 1715;
        
        int zMin = 105;
        int zMax = 1475;

        int x = ran.Next(xMin, xMax); 
        int z = ran.Next(zMin, zMax); 

        healthHelper.transform.position = new Vector3((float)x, 1.6f, (float)z);
        updateHealth("up");
    }
}
