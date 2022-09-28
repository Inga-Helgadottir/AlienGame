using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour{

    public GameObject menu;  
    [SerializeField] GameManager gameManager;
    
    void start(){
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void PlayGame(){
        SceneManager.LoadScene("Level1");
        HideMenu();
    }

    public void HideMenu(){
        menu.SetActive(false);
    }
}
