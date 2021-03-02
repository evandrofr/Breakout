using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coracao : MonoBehaviour{
    [Range(1,15)]
    public float velocidade = 5.0f;
    private Vector3 direcao;

    // Start is called before the first frame update
    void Start(){
        float dirX = 0;
        float dirY = Random.Range(-1.0f, -5.0f);

        direcao = new Vector3(dirX, dirY);
        
    }

    // Update is called once per frame
    void Update(){
        transform.position += direcao * Time.deltaTime * velocidade;
        
    }
}
