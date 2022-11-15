using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.Audio;
using TMPro;

public class PlayerCollision : MonoBehaviour{
    
    public int playerHealth;
    public TextMeshProUGUI healthText;
    public AudioSource alienCrashSound;
    [SerializeField] GameManager gameManager;
    public CameraShake cameraShake;

    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        healthText.text = "Health: " + 30;
    }
    
    void OnTriggerEnter(Collider collider){
        Debug.Log("collider");
        Debug.Log(collider);
        Debug.Log(collider.tag);
        if(collider.tag == "Enemy"){
            playerHealth -= 10;
            healthText.text = "Health: " + playerHealth;
            alienCrashSound.Play();
            StartCoroutine(cameraShake.Shake(.1f, .1f));
            if(playerHealth == 0){
                gameManager.EndGame(false);
            }
        }
    }
}
