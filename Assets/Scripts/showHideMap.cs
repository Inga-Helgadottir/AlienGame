using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class showHideMap : MonoBehaviour{

    public GameObject miniMap;
    public GameObject miniMapBorder;
    public bool mapVisablility = true;

    void awake(){
        miniMap.SetActive(false);
        miniMapBorder.SetActive(false);
    }

    void Update() {
        if(SceneManager.GetActiveScene().name == "Level1"){
            if(Input.GetKeyDown("m")){
                mapVisablility = !mapVisablility;
        
                miniMap.SetActive(mapVisablility);
                miniMapBorder.SetActive(mapVisablility);
            }
        }else{
            miniMap.SetActive(false);
            miniMapBorder.SetActive(false);
        }
    }
}
