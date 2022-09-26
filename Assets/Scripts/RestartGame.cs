using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class RestartGame : MonoBehaviour{

    public GameObject menu; 
    [SerializeField] GameManager gameManager;

    public void restartGame(){
        menu.SetActive(false); 
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.Restart();
        SceneManager.LoadScene("Level1");
    }
}
