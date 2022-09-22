using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;   

public class StartGame : MonoBehaviour{

    public GameObject startMenu;
    public GameObject gameOverMenu;  
    [SerializeField] GameManager gameManager;
    
    void awake(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.showScore();
    }

    public void PlayGame(){
        SceneManager.LoadScene("Level1");
        HideMenu();
    }

    public void HideMenu(){
        startMenu.SetActive(false);
    }
}
