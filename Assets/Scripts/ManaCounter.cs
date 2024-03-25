using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManaCounter : MonoBehaviour
{
    public TextMeshProUGUI mana;
    public int manaTotal;
    private int manaActual;
    private AlertasMensajes alertasMensajes;
    // Start is called before the first frame update
    void Start()
    {
        manaActual = manaTotal;
        StartCoroutine(RegenerarMana());
    }

    // Update is called once per frame
    void Update()
    {
        mana.text = string.Format("Mana:\n"+manaTotal+":"+manaActual);
    }
    public bool QuitarMana (int cantidad)
    {
        int manaActualAux = manaActual - cantidad;
        if (manaActualAux<0)
        {
            alertasMensajes = FindObjectOfType<AlertasMensajes>();
            alertasMensajes.ActualizarMensaje("No hay mana suficiente!");
            return false;
        } else
        {
            manaActual = manaActualAux;
            return true;
        }
    }

    IEnumerator RegenerarMana()
    {
        while (true)
        {
            yield return new WaitForSeconds(1); // Espera 1 segundo
            manaActual = Mathf.Min(manaActual + 5, manaTotal); // Regenera 5 de mana, pero no mas de manaTotal
        }
    }
}
