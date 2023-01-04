using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour{

    public GameObject menu;   
    public static bool GameIsPaused = false;

    void Awake(){
        Time.timeScale = 0f;
    }

    public void PlayGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
        HideMenu();
    }

    public void HideMenu(){
        menu.SetActive(false);
    }
}
