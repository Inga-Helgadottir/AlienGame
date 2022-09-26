using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour{

    void Update(){
        if(Input.GetKeyDown("escape")){
            Application.Quit();
        }
    }

    public void QuitGame(){
        Application.Quit();
    }
}
