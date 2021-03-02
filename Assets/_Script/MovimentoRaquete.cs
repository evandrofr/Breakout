using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoRaquete : MonoBehaviour{

    [Range(1,10)]
    public float velocidade;
    public float cantoDireitoCamera;
    public float cantoEsquerdoCamera;

    public AudioClip som;

    GameManager gm;
    // Start is called before the first frame update
    void Start(){
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update(){
        // primeira execução nas rotinas de Update() da Bola e Raquete.
        if (gm.gameState != GameManager.GameState.GAME) return;

        float inputX = Input.GetAxis("Horizontal");

        transform.position += new Vector3(inputX, 0, 0) * Time.deltaTime * velocidade;
        
        if(Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME){
            gm.ChangeState(GameManager.GameState.PAUSE);
        } 

        if(transform.position.x < cantoEsquerdoCamera){
            transform.position = new Vector2(cantoEsquerdoCamera, transform.position.y);
        }
        if(transform.position.x > cantoDireitoCamera){
            transform.position = new Vector2(cantoDireitoCamera, transform.position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {        
        if(col.gameObject.CompareTag("Coletavel")){
            AudioSource.PlayClipAtPoint(som, transform.position);
            gm.vidas++;
        }
    }
}
