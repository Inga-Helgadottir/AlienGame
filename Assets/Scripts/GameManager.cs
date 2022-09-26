using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  
using UnityEngine.Audio;

public class GameManager : MonoBehaviour{
    public GameObject[] collectables;
    public TextMeshProUGUI scoreText;
    private int score = 0;
    private int howManyCollectables;
    public static bool gameHasEnded = false;
    public static string winnerLoserText = "";
    public AudioSource alienSound;

    void awake(){
        DontDestroyOnLoad(this);
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
        if(score == howManyCollectables && scoreToAdd != 0){
            EndGame(true);
        }
    }

    public void EndGame(bool winLose){//true = won, false = lost
        if(gameHasEnded == false){
            gameHasEnded = true;
            alienSound.Pause();
            if(winLose){
                winnerLoserText = "You won!";
            }else{
                winnerLoserText = "You lost!";
            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1, LoadSceneMode.Additive);
        }
    }

    public void Restart(){
        gameHasEnded = false;
        winnerLoserText = "";
        score = 0;
    }
}
