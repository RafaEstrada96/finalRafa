using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public ManaCounter scriptMana;
    public int costeMana = 30;

    private float tiempoDeEspera = 6f;

    void Start ()
    {
        Destroy(gameObject, tiempoDeEspera);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el objeto colisionado está en la capa 6
        if (collision.gameObject.layer == 6)
        {
            // Destruye el objeto colisionado
            Destroy(collision.gameObject);
            // Destruye el proyectil
            Destroy(gameObject);
        }
    }
    public bool GastarMana (){
        scriptMana = FindObjectOfType<ManaCounter>();
        if (scriptMana != null){
            return scriptMana.QuitarMana(costeMana);
        }
        return false;
    }
}
