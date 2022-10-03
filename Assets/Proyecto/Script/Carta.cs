using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Carta : MonoBehaviour
{

    public Plantilla_Carta plantilla;

    public Image imagenCarta;
    public TextMeshProUGUI textoDescripcion, textoVida, TextoEfecto;
    public bool esAtaque;

    // Start is called before the first frame update
    void Start()
    {
        imagenCarta.sprite = plantilla.imagenCarta;
        textoDescripcion.text = "" + plantilla.TextoDescripcion;
        textoVida.text = "" + plantilla.sumaVida;
        TextoEfecto.text = "" + plantilla.TextoEfecto;
        esAtaque = plantilla.esAtaque;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
