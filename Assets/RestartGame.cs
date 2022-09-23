using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class RestartGame : MonoBehaviour{

    public GameObject menu;  
    [SerializeField] GameManager gameManager;
    
    void start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        // gameManager.showScore(false);
    }

    public void restartGame(){
        Debug.Log("checking");
        menu.SetActive(false); 
        // gameManager.resetScore();
        // gameManager.showScore(true);
        SceneManager.LoadScene("Level1");
    }
}
