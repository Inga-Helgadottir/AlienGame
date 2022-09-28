using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class hideHealthAndScore : MonoBehaviour{
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;
    
    void Start()    {
        healthText.enabled = false;
        scoreText.enabled = false;
    }

    void Update(){
        if(SceneManager.GetActiveScene().name == "Level1"){
            healthText.enabled = true;
            scoreText.enabled = true;
        }else{
            healthText.enabled = false;
            scoreText.enabled = false;
        }
    }

}
