using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instanciaManager;
    public GameObject carta;
    public List<Plantilla_Carta> listaCartas;
    public List<GameObject> cartasTotales;
    public GameObject[] arrayMonstruos;

    public GameObject cartaEnUso;


    public void InstanciaCarta(int posX)
    {
        Instantiate(carta, posicion + new Vector3(posX, 0, 0), Quaternion.identity);
        Carta cartaselect = carta.GetComponent<Carta>();
        cartaselect.plantilla = listaCartas[Random.Range(0, listaCartas.Count)];
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
