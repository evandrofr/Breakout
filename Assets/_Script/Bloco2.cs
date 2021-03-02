using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco2 : MonoBehaviour{
    int vidas;
    public Sprite[] spriteArray;

    void Start(){
        vidas = 2;
    }    
    private void OnTriggerEnter2D(Collider2D col){
        vidas--;
        if(vidas == 1){
            // gameObject.GetComponent<Renderer> ().material.color = Color.red;
            ChangeSprite(1);
        }
        if(vidas <= 0){
            Destroy(gameObject);
        }
    }

    void ChangeSprite(int spriteNumber){
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[spriteNumber]; 
    }
}
