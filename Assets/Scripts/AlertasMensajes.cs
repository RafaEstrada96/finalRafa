using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlertasMensajes : MonoBehaviour
{
    public TextMeshProUGUI alertas;
    public string mensaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alertas.text = string.Format("<color=red>"+mensaje+"</color>");
    }
    public void ActualizarMensaje(string nuevoMensaje)
    {
        mensaje = nuevoMensaje;
        Invoke("DesaparecerMensaje", 2f);
    }
    void DesaparecerMensaje()
    {
        mensaje = "";
    }
}
