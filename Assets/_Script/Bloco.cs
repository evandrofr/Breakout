﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour{
    int vidas;
    void Start(){
        vidas = 1;
    }    
    private void OnTriggerEnter2D(Collider2D col){
        vidas--;
        if(vidas <= 0){
            Destroy(gameObject);
        }
    }
}
