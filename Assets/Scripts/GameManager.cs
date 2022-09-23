using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  

public class GameManager : MonoBehaviour{
    public GameObject[] collectables;
    public TextMeshProUGUI scoreText;
    public int score;
    private int howManyCollectables;
    bool gameHasEnded = false;
    
    void awake(){
        score = 0;
    }

    void start(){
        collectables = GameObject.FindGameObjectsWithTag("Collectable");
        howManyCollectables = 0;
    }

    void Update(){
        if(howManyCollectables == 0){
            howManyCollectables = GameObject.FindGameObjectsWithTag("Collectable").Length;
            UpdateScore(0);
        }
    }

    // public void showScore(bool showText){
    //     scoreText.gameObject.SetActive(showText);
    // }

    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text = "Score: " + score + "/" + howManyCollectables;
        if(score == howManyCollectables && scoreToAdd != 0){
            EndGame();
        }
    }

    public void resetScore(){
        score = 0;
    }

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            SceneManager.LoadScene("GameOverScreenMenu");
            Application.Quit();
        }
    }

    void Restart(){
        gameHasEnded = false;
    }
}
