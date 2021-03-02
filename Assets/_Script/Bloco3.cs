using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco3 : MonoBehaviour{
    int vidas;
    public Sprite[] spriteArray;
    public GameObject Coracao;
    

    void Start(){
        vidas = 3;
    }    
    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.name == "Bola"){
            vidas--;
            if(vidas == 2){
                // gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
                ChangeSprite(1);
            }
            if(vidas == 1){
                // gameObject.GetComponent<Renderer> ().material.color = Color.red;
                ChangeSprite(2);
                System.Random rnd = new System.Random();
                int contemCoracao = rnd.Next(1,11);
                Debug.Log($"Número: {contemCoracao}");
                if(contemCoracao > 9){
                    Instantiate(Coracao, this.transform.position, Quaternion.identity, transform);
                }
            }
            if(vidas <= 0){
                Destroy(gameObject);
            }
        }
    }

    void ChangeSprite(int spriteNumber){
        gameObject.GetComponent<SpriteRenderer>().sprite = spriteArray[spriteNumber]; 
    }
}