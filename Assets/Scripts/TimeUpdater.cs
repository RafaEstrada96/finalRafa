using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeUpdater : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    // Start is called before the first frame update
    void Start()
    {
        //textoTiempo = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float tiempoTranscurrido = Time.timeSinceLevelLoad;

        int minutos = Mathf.FloorToInt(tiempoTranscurrido / 60);
        int segundos = Mathf.FloorToInt(tiempoTranscurrido % 60);

        textoTiempo.text = string.Format("Tiempo\n {0:00}:{1:00}", minutos, segundos);
    }
}
