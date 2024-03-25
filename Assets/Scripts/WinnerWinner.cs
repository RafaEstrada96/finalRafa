using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerWinner : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        if  (other.tag == "Player"){
            
            print("Has Ganado. Fin del juego.");
            PlayerWin();
        }
        
    }

    private void PlayerWin(){
        LevelManager.instance.WinnerWinner();
        gameObject.SetActive(false);
    }
}
