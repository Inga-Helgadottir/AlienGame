using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shootable : MonoBehaviour{

    [SerializeField] Image _healthBarSprite;
    public int currentHealth = 3;
    
    public void Damage(int damageAmount){
        currentHealth-= damageAmount;
        UpdateHealthBar(3);
        if(currentHealth <= 0){
            gameObject.SetActive(false);
        }
    }
    
    public void UpdateHealthBar(float maxHealth){
        _healthBarSprite.fillAmount = currentHealth / maxHealth;
    }

}
