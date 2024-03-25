using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinalPosition : MonoBehaviour
{
    public LifeCounter scriptVidas;
    private static int vidas = 5;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        
        if  (other.tag == "Obstaculo"){
            scriptVidas = FindObjectOfType<LifeCounter>();
            if (scriptVidas != null){
                vidas = vidas - 1;
                scriptVidas.contVidas = vidas;
                if (scriptVidas.contVidas < 0){
                    print("Has Perdido. Fin del juego.");
                    PlayerDied();
                }
            }
            Respawn respawnC = this.GetComponent<Respawn>();
            respawnC.RespawnCharacter();
        }
        
    }

    private void PlayerDied(){
        
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }

}
