using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PositionPlayer : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI textoTiempo;

    // Update is called once per frame
    void Update()
    {
        if (player != null && textoTiempo != null){
            Vector3 playerPosition = player.transform.position;

            string positionString = string.Format("Pos Player: ({0}, {1}, {2})", playerPosition.x, playerPosition.y, playerPosition.z);
            textoTiempo.text = positionString;
        }
    }
}