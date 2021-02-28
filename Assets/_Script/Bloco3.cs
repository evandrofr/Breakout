using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco3 : MonoBehaviour{
    int vidas;
    void Start(){
        vidas = 3;
    }    
    private void OnTriggerEnter2D(Collider2D col){
        vidas--;
        if(vidas == 2){
            gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
        }
        if(vidas == 1){
            gameObject.GetComponent<Renderer> ().material.color = Color.red;
        }
        if(vidas <= 0){
            Destroy(gameObject);
        }
    }
}