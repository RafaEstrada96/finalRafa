using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;

    private void Awake(){
        if (LevelManager.instance == null) instance = this;
        else Destroy(gameObject);
    }
    public void GameOver(){
        ChangeCamera cam = GetComponent<ChangeCamera>();
        cam.thirdCamera.SetActive(true);
        cam.firstCamera.SetActive(false);
        UIManager _ui = GetComponent<UIManager>();
        if (_ui != null){
            _ui.ToggleDeathPanel();
        }
    }
    public void WinnerWinner(){
        ChangeCamera cam = GetComponent<ChangeCamera>();
        cam.thirdCamera.SetActive(true);
        cam.firstCamera.SetActive(false);
        UIManagerVictory _ui = GetComponent<UIManagerVictory>();
        if(_ui != null){
            _ui.ToggleWinPanel();
        }
    }
}