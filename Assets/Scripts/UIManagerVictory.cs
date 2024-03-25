using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerVictory : MonoBehaviour
{
    [SerializeField] GameObject winPanel;

    public void ToggleWinPanel(){
        winPanel.SetActive(!winPanel.activeSelf);
    }
}
