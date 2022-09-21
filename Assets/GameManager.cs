using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{
    public GameObject[] collectables;
    public TextMeshProUGUI scoreText;
    private int score;
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

    public void UpdateScore(int scoreToAdd){
        score += scoreToAdd;
        scoreText.text = "Score: " + score + "/" + howManyCollectables;
        if(score == howManyCollectables){
            EndGame();
        }
    }

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            Application.Quit();
            // Invoke("Restart", 2f);
        }
    }

    void Restart(){
        gameHasEnded = false;
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
