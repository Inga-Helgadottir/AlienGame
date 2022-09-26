using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinnerLoserText : MonoBehaviour{
    public TextMeshProUGUI winnerLoserText;

    void Update(){
        if(GameManager.gameHasEnded){
            winnerLoserText.text = GameManager.winnerLoserText;
        }
    }
}
