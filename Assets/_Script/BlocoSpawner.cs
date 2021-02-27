using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour{

    public GameObject Bloco;
    GameManager gm;

    // Start is called before the first frame update
    void Start(){
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();

    }

    void Construir(){
        if (gm.gameState == GameManager.GameState.MENU){
            for(int i = 0; i < 10; i++){
                for(int j = 0; j < 4; j++){
                    Vector3 posicao = new Vector3(-10 + 2.2f * i, 4 - 0.9f * j);
                    Instantiate(Bloco, posicao, Quaternion.identity, transform);
                }
            }
        }
    }

    // Update is called once per frame
    void Update(){
        if (transform.childCount <= 0 && gm.gameState == GameManager.GameState.GAME){
            gm.ChangeState(GameManager.GameState.ENDGAME);   
        }
    }
}
