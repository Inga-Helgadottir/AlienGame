using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class playCollectableSound : MonoBehaviour{
    
    public AudioSource collectableClip;

    void OnTriggerEnter(Collider other){
        if(other.tag == "Collectable"){
            collectableClip.Play();
        }
    }
}
