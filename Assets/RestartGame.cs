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
    }

    public void restartGame(){
        menu.SetActive(false); 
        SceneManager.LoadScene("Level1");
    }
}
