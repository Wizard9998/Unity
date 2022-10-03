using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="ModeloCarta", menuName="PlantillaCarta")]

public class Plantilla_Carta : ScriptableObject
{
    public Sprite imagenCarta;
    [Space(50)]
    [TextArea(3, 10)]
    public string TextoDescripcion;
    public int restaVida;
    public int sumaVida;
    public int TextoEfecto;
    public bool esAtaque;
}
