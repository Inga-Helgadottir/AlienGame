using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour{

    public GameObject startMenu;
    public GameObject gameOverMenu;
    
    public void PlayGame(){
        SceneManager.LoadScene("Level1");
        HideMenu();
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }

    public void HideMenu(){
        startMenu.SetActive(false);
    }
}
