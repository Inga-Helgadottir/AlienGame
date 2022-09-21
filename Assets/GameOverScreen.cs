using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScreen : MonoBehaviour{
    
    public TextMeshProUGUI winnerOrLoserText;

    public void Setup(int score){
        // GameObject.SetActive(true);
        winnerOrLoserText.text = score + "POINTS";
    }
}
