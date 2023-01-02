using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showHideMap : MonoBehaviour{

    public GameObject miniMap;
    public GameObject miniMapBorder;

    void awake(){
        miniMap.SetActive(false);
        miniMapBorder.SetActive(false);
    }

    void Update() {
        if(SceneManager.GetActiveScene().name == "Level1"){
            miniMap.SetActive(true);
            miniMapBorder.SetActive(true);

        }else{
            miniMap.SetActive(false);
            miniMapBorder.SetActive(false);
        }
    }
}
