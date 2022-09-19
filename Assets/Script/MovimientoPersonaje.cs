using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rigidBody;
    private bool mirandoDerecha = true;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }
    void ProcesarMovimiento()
    {
        //Logica de Movimiento
        float inputMovimiento = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(inputMovimiento * velocidad, rigidBody.velocity.y);

        GestionarOrientacion(inputMovimiento);
    }

    void GestionarOrientacion(float inputmovimiento)
    {
        //Si se cumple condición
        if ((mirandoDerecha == true && inputmovimiento < 0) || (mirandoDerecha == false && inputmovimiento > 0))
        {
            //Ejecutar codigo de volteado 
            mirandoDerecha = !mirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

    }
}