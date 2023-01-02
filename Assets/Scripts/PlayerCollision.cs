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
    public AudioSource healthHelperSound;
    [SerializeField] GameManager gameManager;
    public CameraShake cameraShake;
    public System.Random ran = new System.Random();
    public GameObject healthHelper;
    Vector3 pos;
    public float height;
    RaycastHit hit;

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
            healthHelperSound.Play();
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
        int xMin = 798;
        int xMax = 1679;
        
        int zMin = 39;
        int zMax = 1492;

        int thex = ran.Next(xMin, xMax); 
        int thez = ran.Next(zMin, zMax); 

        pos.x = thex;
        pos.z = thez;

        Vector3 signPosition = new Vector3(thex, 0, thez);
        pos.y = Terrain.activeTerrain.SampleHeight(signPosition) + Terrain.activeTerrain.GetPosition().y; 
        pos.y += 1.6f; 

        healthHelper.transform.position = pos;
        Debug.Log("here, x, y, z");
        Debug.Log(pos.x);
        Debug.Log(pos.y);
        Debug.Log(pos.z);
        updateHealth("up");
    }
}
