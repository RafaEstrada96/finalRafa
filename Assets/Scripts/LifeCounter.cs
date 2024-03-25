using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeCounter : MonoBehaviour
{
    public TextMeshProUGUI vidas;
    public int contVidas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        vidas.text = string.Format("Vidas = "+contVidas);
        
    }
}
