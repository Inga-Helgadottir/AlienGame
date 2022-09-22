using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;   

public class StartGame : MonoBehaviour{

    public GameObject startMenu;
    public GameObject gameOverMenu;  
    [SerializeField] GameManager gameManager;
    
    void start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.showScore(false);
    }

    public void PlayGame(){
        SceneManager.LoadScene("Level1");
        HideMenu();
        gameManager.showScore(true);
    }

    public void HideMenu(){
        startMenu.SetActive(false);
    }
}
